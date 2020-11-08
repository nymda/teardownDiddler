using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder.Mods
{
    public class slowmo
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
        public const float defaultSpeed = 0.016f;
        public float currentSpeed = 0.016f;
        public int discardRef;

        public slowmo(offsetPackage pack)
        {
            this.pack = pack;
        }

        public void patchGameSpeed()
        {
            byte[] nop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0x242D8, nop, nop.Length, ref discardRef); //patch instructions for step
            byte[] newSpeedBytes = BitConverter.GetBytes(currentSpeed);
            WriteProcessMemory(pack.processHandle, pack.gameInstance + 0x144, newSpeedBytes, newSpeedBytes.Length, ref discardRef); //set to current speed
            Console.WriteLine("Patch:" + currentSpeed);
        }

        public void unpatchGameSpeed()
        {
            //this is a constant value, if the user unchecks this then just set it to the default speed
            byte[] newSpeedBytes = BitConverter.GetBytes(defaultSpeed);
            WriteProcessMemory(pack.processHandle, pack.gameInstance + 0x144, newSpeedBytes, newSpeedBytes.Length, ref discardRef);
        }

        public void setGameSpeed(int sliderValue)
        {
            float newSpeed = defaultSpeed / (sliderValue / 4f);
            byte[] newSpeedBytes = BitConverter.GetBytes(newSpeed);
            WriteProcessMemory(pack.processHandle, pack.gameInstance + 0x144, newSpeedBytes, newSpeedBytes.Length, ref discardRef);
            currentSpeed = newSpeed;
            Console.WriteLine(currentSpeed);
        }
    }
}
