using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{
    public class step
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        #endregion
        offsetPackage pack { get; set; }
        public step(offsetPackage pack)
        {
            this.pack = pack;
        }
        public int discardRef = 0;
        public void patchStep()
        {
            byte[] nop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6108, nop, nop.Length, ref discardRef); //patch instructions for step
        }

        public void unPatchStep()
        {
            byte[] inst = new byte[] { 0xF3, 0x0F, 0x11, 0x91, 0xF8, 0x00, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6108, inst, inst.Length, ref discardRef); //unpatch instructions for step
        }

        public void setStepHeight(int step)
        {
            byte[] newheight = BitConverter.GetBytes((float)(step / 2));
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0xF8, newheight, newheight.Length, ref discardRef);
        }
    }
}
