using Jupiter;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeardownMemoryModder.Mods;

namespace TeardownMemoryModder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public offsetPackage pack;
        public removeBoundaries removeBoundaries;
        public teleport teleport;
        public jetpack jetpack;
        public immortality immortality;

        public string debugText = "";
        public int unusedRef = 0;
        public List<float> storedPosition = new List<float> { 0f, 0f, 0f };
        public byte[] campos = new byte[84];
        public byte[] camang = new byte[84];

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        float x;
        float y;
        float z;

        byte[] origionalWallCode = new byte[8];

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            init();
        }

        public void init()
        {
            Process[] teardowns = Process.GetProcessesByName("teardown");
            if (teardowns.Length > 0)
            {
                //calculate nessicary offsets
                Process process;
                IntPtr handle;
                Int64 playerInstance;
                Int64 gameInstance;
                Int32 processHandle;
                Int64 sceneInstance;

                process = teardowns[0];
                handle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);

                Byte[] buffer = new Byte[8];
                Int32 bytesRead = 0;
                processHandle = (Int32)handle;

                debugText = debugText + "Entrypoint: 0x" + processHandle.ToString("X");

                Int64 baseAddress = process.MainModule.BaseAddress.ToInt64() + 0x3E3520;
                buffer = new byte[8];
                ReadProcessMemory(processHandle, baseAddress, buffer, buffer.Length, ref bytesRead);
                gameInstance = BitConverter.ToInt64(buffer, 0);

                debugText = debugText + "\nGame instance: 0x" + gameInstance.ToString("X");

                buffer = new byte[8];
                Int64 playerPtr = gameInstance + 0xA0;
                ReadProcessMemory(processHandle, playerPtr, buffer, buffer.Length, ref bytesRead);
                playerInstance = BitConverter.ToInt64(buffer, 0);

                debugText = debugText + "\nPlayer instance: 0x" + playerInstance.ToString("X");

                buffer = new byte[8];
                Int64 scenePtr = gameInstance + 0x40;
                ReadProcessMemory(processHandle, scenePtr, buffer, buffer.Length, ref bytesRead);
                sceneInstance = BitConverter.ToInt64(buffer, 0);

                debugText = debugText + "\nScene instance: 0x" + sceneInstance.ToString("X");

                Console.WriteLine(playerPtr);

                int read_vcount = 0;
                ReadProcessMemory(processHandle, sceneInstance + 0x530, origionalWallCode, origionalWallCode.Length, ref read_vcount);

                //create the offsetpackage
                pack = new offsetPackage(process, handle, playerInstance, gameInstance, processHandle, sceneInstance);

                //initialise mods
                removeBoundaries = new removeBoundaries(pack);
                teleport = new teleport(pack);
                jetpack = new jetpack(pack);
                immortality = new immortality(pack);

                this.Text = "Teardown diddler [ACTIVE]";

                updateCurrentPositions.Start();
            }
            else
            {
                this.Text = "Teardown diddler [INACTIVE]";
            }
        }

        private void updateCurrentPositions_Tick(object sender, EventArgs e)
        {
            //---------
            int unusedRef = 0;
            lbl_debugInfo.Text = debugText;
            //---------

            ///get key states
            short keyStateI = GetAsyncKeyState(0x49);
            bool isIPressed = ((keyStateI >> 15) & 0x0001) == 0x0001;

            short keyStateK = GetAsyncKeyState(0x4B);
            bool isKPressed = ((keyStateK >> 15) & 0x0001) == 0x0001;

            short keyStateSpace = GetAsyncKeyState(0x20);
            bool isSpacePressed = ((keyStateSpace >> 15) & 0x0001) == 0x0001;

            //read current position
            List<float> TmpPos = teleport.readPositon();
            curCords.Text = String.Format("Current: {0} | {1} | {2}", numProc(TmpPos[0]), numProc(TmpPos[1]), numProc(TmpPos[2]));

            ///save current position
            if (isIPressed && GetActiveWindowTitle() == "Teardown")
            {
                List<float> pos = teleport.savePosition();
                savedCords.Text = String.Format("Current: {0} | {1} | {2}", numProc(pos[0]), numProc(pos[1]), numProc(pos[2]));
            }

            ///load saved position
            if (isKPressed && GetActiveWindowTitle() == "Teardown")
            {
                teleport.loadPosition();
            }

            ///use jetpack
            if (isSpacePressed && cbJetpack.Checked)
            {
                jetpack.boost();
            }
            else
            {
                jetpack.first = true;
            }
        }

        public string numProc(float inp)
        {
            string proc;
            if (inp > 999.99 || inp < -999.99)
            {
                proc = "_ERROR";
            }
            else
            {
                proc = inp.ToString();
            }
            proc = String.Join("", proc.Take(6));
            if (proc.Length < 6)
            {
                proc = "0" + proc;
            }
            return proc;
        }

        private void btnRemoveBoundaries_Click(object sender, EventArgs e)
        {
            removeBoundaries.activate();
        }

        private void cbStronk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStronk.Checked)
            {
                immortality.patchImmortality();
                nudHealthSpeed.Enabled = true;
            }
            else
            {
                immortality.unPatchImmortality();
                nudHealthSpeed.Enabled = false;
            }
        }

        private void nudHealthSpeed_ValueChanged(object sender, EventArgs e)
        {
            immortality.setCurrentHealth((float)nudHealthSpeed.Value);
            Console.WriteLine(nudHealthSpeed.Value);
        }
    }
}
