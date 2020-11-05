using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{
    public class jetpack
    {
        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        #endregion
        offsetPackage pack { get; set; }
        public bool first { get; set; }
        public jetpack(offsetPackage pack)
        {
            this.pack = pack;
        }

        float setVelo = 0;
        int unusedRef = 0;
        public void boost()
        {
            if (first)
            {
                byte[] currentVelo = new byte[4];
                ReadProcessMemory(pack.processHandle, pack.playerInstance + 0x38 + 4, currentVelo, currentVelo.Length, ref unusedRef);
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
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x38 + 4, arrVelocity, arrVelocity.Length, ref unusedRef);
        }

    }
}
