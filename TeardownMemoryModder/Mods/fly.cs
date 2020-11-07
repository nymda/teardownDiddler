using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TeardownMemoryModder.Mods
{
    public class fly
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
        public int discardRef = 0;
        Timer flightKeyHandler = new Timer();
        public bool inFlightMode { get; set; }
        public fly(offsetPackage pack)
        {
            this.pack = pack;
            flightKeyHandler.Interval = 30;
            flightKeyHandler.Elapsed += OnTimedEvent;
        }

        public void beginFly()
        {
            //NOP instructions that effect the players Y velocity
            byte[] nop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0x1C3E8C, nop.Take(4).ToArray(), 4, ref discardRef);
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6D49, nop.Take(3).ToArray(), 3, ref discardRef);
            inFlightMode = true;
            Console.WriteLine(inFlightMode);
            flightKeyHandler.Start();
        }

        public void endFly()
        {
            byte[] instOne = new byte[] { 0xF2, 0x0F, 0x11, 0x06 };
            byte[] instTwo = new byte[] { 0x89, 0x43, 0x3C };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0x1C3E8C, instOne, instOne.Length, ref discardRef);
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6D49, instTwo, instTwo.Length, ref discardRef);
            inFlightMode = false;
            flightKeyHandler.Stop();
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            short keyStateSpace = GetAsyncKeyState(0x20);
            bool isSpacePressed = ((keyStateSpace >> 15) & 0x0001) == 0x0001;

            short keyStateControl = GetAsyncKeyState(0x11);
            bool isControlPressed = ((keyStateControl >> 15) & 0x0001) == 0x0001;

            if (isSpacePressed)
            {
                byte[] upVelo = BitConverter.GetBytes(5f);
                WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x38 + 4, upVelo, upVelo.Length, ref discardRef);
            }
            else if (isControlPressed)
            {
                byte[] downVelo = BitConverter.GetBytes(-5f);
                WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x38 + 4, downVelo, downVelo.Length, ref discardRef);
            }
            else
            {
                byte[] stableVelo = BitConverter.GetBytes(0.165f);
                WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x38 + 4, stableVelo, stableVelo.Length, ref discardRef);
            }

            //A618A
        }
    }
}
