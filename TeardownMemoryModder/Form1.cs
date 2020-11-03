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

        public List<float> storedPosition = new List<float> { };

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

            if(teardowns.Length > 0)
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

                int read_vcount = 0;
                ReadProcessMemory(processHandle, sceneInstance + 0x530, origionalWallCode, origionalWallCode.Length, ref read_vcount);

                updateCurrentPositions.Start();
            }
            else
            {
                this.Text = "Teardown diddler [TD NOT RUNNING]";
            }
            
        }

        public float setVelo = 3;
        private void updateCurrentPositions_Tick(object sender, EventArgs e)
        {
            Byte[] buffer = new byte[12];
            int read = 0;
            ReadProcessMemory(processHandle, playerInstance, buffer, buffer.Length, ref read);

            x = BitConverter.ToSingle(buffer, 0);
            y = BitConverter.ToSingle(buffer, 4);
            z = BitConverter.ToSingle(buffer, 8);

            cPosX.Text = "Current X: " + x.ToString("0.00");
            cPosY.Text = "Current Y: " + y.ToString("0.00");
            cPosZ.Text = "Current Z: " + z.ToString("0.00");

            short keyStateI = GetAsyncKeyState(0x49);
            bool isIPressed = ((keyStateI >> 15) & 0x0001) == 0x0001;

            short keyStateK = GetAsyncKeyState(0x4B);
            bool isKPressed = ((keyStateK >> 15) & 0x0001) == 0x0001;

            short keyStateSpace = GetAsyncKeyState(0x20);
            bool isSpacePressed = ((keyStateSpace >> 15) & 0x0001) == 0x0001;

            if (isIPressed)
            {
                btnSavePos_Click(null, null);
            }
            if (isKPressed)
            {
                btnLoadPos_Click(null, null);
            }

            if (isSpacePressed && cbJetpack.Checked)
            {
                if(setVelo > 6)
                {
                    setVelo = 6;
                }
                else
                {
                    setVelo += 0.5f;
                }
                int wrote = 0;
                List<byte> nvelocity = new List<Byte> { };
                nvelocity.AddRange(BitConverter.GetBytes(setVelo));
                byte[] arrVelocity = nvelocity.ToArray();
                WriteProcessMemory(processHandle, playerInstance + 0x38+4, arrVelocity, arrVelocity.Length, ref wrote);
            }
            else
            {
                setVelo = 3;
            }
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
                throw new ArgumentException($"No process with name {processName} is currently running");
            }
            var module = process.Modules.Cast<ProcessModule>().SingleOrDefault(m => string.Equals(m.ModuleName, moduleName, StringComparison.OrdinalIgnoreCase));
            return module?.BaseAddress ?? IntPtr.Zero;
        }

        private void btnSavePos_Click(object sender, EventArgs e)
        {
            storedPosition = new List<float> { x, y, z };
            sPosX.Text = "Saved X: " + x.ToString("0.00");
            sPosY.Text = "Saved Y: " + y.ToString("0.00");
            sPosZ.Text = "Saved Z: " + z.ToString("0.00");
        }

        private void btnLoadPos_Click(object sender, EventArgs e)
        {
            List<Byte> lBuffer = new List<Byte> { };
            lBuffer.AddRange(BitConverter.GetBytes(storedPosition[0]));
            lBuffer.AddRange(BitConverter.GetBytes(storedPosition[1]));
            lBuffer.AddRange(BitConverter.GetBytes(storedPosition[2]));
            byte[] buffer = lBuffer.ToArray();
            int wrote = 0;
            WriteProcessMemory(processHandle, playerInstance, buffer, buffer.Length, ref wrote);
        }

        private void cbDeleteBoundaries_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeleteBoundaries.Checked)
            {
                byte[] noWalls = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                int wrote = 0;
                WriteProcessMemory(processHandle, sceneInstance + 0x530, noWalls, noWalls.Length, ref wrote);
            }
            else
            {
                int wrote = 0;
                WriteProcessMemory(processHandle, sceneInstance + 0x530, origionalWallCode, origionalWallCode.Length, ref wrote);
            }
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
    }
}
