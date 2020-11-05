using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder
{
    public class removeBoundaries
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        #endregion

        public bool isActive = false;
        public int discardRef = 0;
        offsetPackage pack { get; set; }

        public removeBoundaries(offsetPackage pack)
        {
            this.pack = pack;
        }

        public void activate()
        {
            isActive = true;
            long modLocation = pack.sceneInstance + 0x530;
            byte[] noWalls = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, modLocation, noWalls, noWalls.Length, ref discardRef);
        }
    }
}
