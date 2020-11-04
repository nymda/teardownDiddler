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

        [DllImport("kernel32.dll")]
        internal static extern bool IsWow64Process(SafeProcessHandle processHandle, out bool isWow64Process);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
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
        Process process;
        IntPtr handle;
        Int64 playerInstance;
        Int64 gameInstance;
        Int32 processHandle;
        Int64 sceneInstance;

        float x;
        float y;
        float z;

        byte[] origionalWallCode = new byte[8];

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            Process[] teardowns = Process.GetProcessesByName("teardown");

            if (teardowns.Length > 0)
            {
                process = teardowns[0];
                handle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);

                Byte[] buffer = new Byte[8];
                Int32 bytesRead = 0;
                processHandle = (Int32)handle;

                Int64 baseAddress = process.MainModule.BaseAddress.ToInt64() + 0x3E3520;
                buffer = new byte[8];
                ReadProcessMemory(processHandle, baseAddress, buffer, buffer.Length, ref bytesRead);
                gameInstance = BitConverter.ToInt64(buffer, 0);

                buffer = new byte[8];
                Int64 playerPtr = gameInstance + 0xA0;
                ReadProcessMemory(processHandle, playerPtr, buffer, buffer.Length, ref bytesRead);
                playerInstance = BitConverter.ToInt64(buffer, 0);

                buffer = new byte[8];
                Int64 scenePtr = gameInstance + 0x40;
                ReadProcessMemory(processHandle, scenePtr, buffer, buffer.Length, ref bytesRead);
                sceneInstance = BitConverter.ToInt64(buffer, 0);

                Console.WriteLine(playerPtr);

                int read_vcount = 0;
                ReadProcessMemory(processHandle, sceneInstance + 0x530, origionalWallCode, origionalWallCode.Length, ref read_vcount);

                updateCurrentPositions.Start();
            }
            else
            {
                this.Text = "Teardown diddler [TD NOT RUNNING]";
            }

        }

        private void updateCurrentPositions_Tick(object sender, EventArgs e)
        {
            //---------
            int unusedRef = 0;
            Byte[] buffer = new byte[12];
            //---------

            ///read current position from memory
            ReadProcessMemory(processHandle, playerInstance, buffer, buffer.Length, ref unusedRef);
            x = BitConverter.ToSingle(buffer, 0);
            y = BitConverter.ToSingle(buffer, 4);
            z = BitConverter.ToSingle(buffer, 8);
            curCords.Text = String.Format("Current: {0} | {1} | {2}", numProc(x), numProc(y), numProc(z));

            ///get key states
            short keyStateI = GetAsyncKeyState(0x49);
            bool isIPressed = ((keyStateI >> 15) & 0x0001) == 0x0001;

            short keyStateK = GetAsyncKeyState(0x4B);
            bool isKPressed = ((keyStateK >> 15) & 0x0001) == 0x0001;

            short keyStateSpace = GetAsyncKeyState(0x20);
            bool isSpacePressed = ((keyStateSpace >> 15) & 0x0001) == 0x0001;

            ///save current position
            if (isIPressed && GetActiveWindowTitle() == "Teardown")
            {
                unusedRef = 0;
                ReadProcessMemory(processHandle, playerInstance + 0x0060, campos, campos.Length, ref unusedRef);
                ReadProcessMemory(processHandle, playerInstance + 0x00C4, camang, camang.Length, ref unusedRef);
                storedPosition = new List<float> { x, y, z };
                savedCords.Text = String.Format("  Saved: {0} | {1} | {2}", numProc(x), numProc(y), numProc(z));
            }

            ///load saved position
            if (isKPressed && GetActiveWindowTitle() == "Teardown")
            {
                List<Byte> lBuffer = new List<Byte> { };
                lBuffer.AddRange(BitConverter.GetBytes(storedPosition[0]));
                lBuffer.AddRange(BitConverter.GetBytes(storedPosition[1]));
                lBuffer.AddRange(BitConverter.GetBytes(storedPosition[2]));
                buffer = lBuffer.ToArray();
                unusedRef = 0;
                WriteProcessMemory(processHandle, playerInstance, buffer, buffer.Length, ref unusedRef);
                if (campos != null)
                {
                    WriteProcessMemory(processHandle, playerInstance + 0x0060, campos, campos.Length, ref unusedRef);
                    WriteProcessMemory(processHandle, playerInstance + 0x00C4, camang, camang.Length, ref unusedRef);
                }
            }

            ///use jetpack
            if (isSpacePressed && cbJetpack.Checked)
            {
                if (first)
                {
                    byte[] currentVelo = new byte[4];
                    ReadProcessMemory(processHandle, playerInstance + 0x38 + 4, currentVelo, currentVelo.Length, ref unusedRef);
                    setVelo = BitConverter.ToSingle(currentVelo, 0);
                    first = false;
                }
                if (setVelo > 12)
                {
                    setVelo = 12;
                }
                else
                {
                    setVelo += 1.5f;
                }

                List<byte> nvelocity = new List<Byte> { };
                nvelocity.AddRange(BitConverter.GetBytes(setVelo));
                byte[] arrVelocity = nvelocity.ToArray();
                WriteProcessMemory(processHandle, playerInstance + 0x38 + 4, arrVelocity, arrVelocity.Length, ref unusedRef);
            }
            else
            {
                first = true;
            }

            ///godmode
            if (cbStronk.Checked)
            {
                int wrote = 0;
                byte[] stronk = BitConverter.GetBytes(10f);
                WriteProcessMemory(processHandle, playerInstance + 0x015C, stronk, stronk.Length, ref wrote);
            }
        }

        public float setVelo = 3;
        bool first = true;

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

        public IntPtr GetModuleBaseAddress(string processName, string moduleName)
        {
            Process process;

            try
            {
                process = Process.GetProcessesByName(processName)[0];
            }

            catch (IndexOutOfRangeException)
            {
                throw new ArgumentException("No process");
            }
            var module = process.Modules.Cast<ProcessModule>().SingleOrDefault(m => string.Equals(m.ModuleName, moduleName, StringComparison.OrdinalIgnoreCase));
            return module?.BaseAddress ?? IntPtr.Zero;
        }
    
        private void btnSavePos_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPos_Click(object sender, EventArgs e)
        {

        }

        private void btnSetFlashlightColour_Click(object sender, EventArgs e)
        {
            setColour.FullOpen = true;
            if(setColour.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = new byte[64];

                int read = 0;
                ReadProcessMemory(processHandle, sceneInstance + 0xE8, buffer, buffer.Length, ref read);
            }
        }

        private void btnRemoveBoundaries_Click(object sender, EventArgs e)
        {
            byte[] noWalls = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int wrote = 0;
            WriteProcessMemory(processHandle, sceneInstance + 0x530, noWalls, noWalls.Length, ref wrote);
        }
    }
}
