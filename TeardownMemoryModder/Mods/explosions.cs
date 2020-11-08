using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{
    public class explosions
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        #endregion
        offsetPackage pack { get; set; }
        public int discardRef;

        public explosions(offsetPackage pack)
        {
            this.pack = pack;
        }

        public void patchExplosions()
        {

        }

        public void unPatchExplosions()
        {

        }
    }
}
