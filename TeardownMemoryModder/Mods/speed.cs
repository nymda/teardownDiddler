using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{
    public class speed
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        #endregion
        offsetPackage pack { get; set; }
        public int discardRef = 0;

        public speed()
        {
            this.pack = pack;
        }
        public void patchSpeed()
        {
            byte[] nop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            byte[] newSpeedInst = new byte[] { 0xF3, 0x0F, 0x10, 0x81, 0x60, 0x01, 0x00, 0x00 };
            byte[] defSpeed = BitConverter.GetBytes(25f);
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6182, nop, nop.Length, ref discardRef); //nop instruction
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA618a, newSpeedInst, newSpeedInst.Length, ref discardRef); //patch instruction
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x0160, defSpeed, defSpeed.Length, ref discardRef); //put default value at 0x0160
        }
        public void unPathSpeec()
        {

        }

    }
}
