using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{

    public class immortality
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        #endregion
        offsetPackage pack { get; set; }
        public immortality(offsetPackage pack)
        {
            this.pack = pack;
        }
        public int discardRef = 0;
        public void patchImmortality()
        {
            byte[] nop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6182, nop, nop.Length, ref discardRef); //patch instructions for speedhack
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA8CF3, nop, nop.Length, ref discardRef); //patch instrustions for immortality
        }

        public void unPatchImmortality()
        {
            byte[] func = new byte[] { 0xF3, 0x0F, 0x11, 0x91, 0x5C, 0x01, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA8A63, func, func.Length, ref discardRef);
        }

        public void setCurrentHealth(float health)
        {
            byte[] stronk = BitConverter.GetBytes(health);
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x015C, stronk, stronk.Length, ref discardRef);
        }
    }
}
