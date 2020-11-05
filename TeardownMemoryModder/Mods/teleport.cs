using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{

    public class teleport
    {
        public teleport(offsetPackage pack)
        {
            this.pack = pack;
        }

        #region kernalImports
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        #endregion

        public int discardRef = 0;
        offsetPackage pack { get; set; }

        public byte[] campos = new byte[84];
        public byte[] camang = new byte[84];
        public byte[] position = new byte[12];
        public List<float> storedPosition = new List<float> { 0f, 0f, 0f };

        public List<float> savePosition()
        {        
            ReadProcessMemory(pack.processHandle, pack.playerInstance, position, position.Length, ref discardRef);
            ReadProcessMemory(pack.processHandle, pack.playerInstance + 0x0060, campos, campos.Length, ref discardRef);
            ReadProcessMemory(pack.processHandle, pack.playerInstance + 0x00C4, camang, camang.Length, ref discardRef);

            storedPosition[0] = BitConverter.ToSingle(position, 0);
            storedPosition[1] = BitConverter.ToSingle(position, 4);
            storedPosition[2] = BitConverter.ToSingle(position, 8);
            return storedPosition;
        }

        public void loadPosition()
        {
            WriteProcessMemory(pack.processHandle, pack.playerInstance, position, position.Length, ref discardRef);
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x0060, campos, campos.Length, ref discardRef);
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x00C4, camang, camang.Length, ref discardRef);
        }
        public List<float> readPositon()
        {
            List<float> tmpPos = new List<float> { 0f, 0f, 0f };
            byte[] tmp = new byte[12];
            ReadProcessMemory(pack.processHandle, pack.playerInstance, tmp, tmp.Length, ref discardRef);
            tmpPos[0] = BitConverter.ToSingle(tmp, 0);
            tmpPos[1] = BitConverter.ToSingle(tmp, 4);
            tmpPos[2] = BitConverter.ToSingle(tmp, 8);
            return tmpPos;
        }
    }
}
