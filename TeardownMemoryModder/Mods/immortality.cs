﻿using System;
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
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6182, nop, nop.Length, ref discardRef); //nop instruction 1
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA8CF3, nop, nop.Length, ref discardRef); //patch instrustions for basic damage
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA7FB7, nop, nop.Length, ref discardRef); //patch instrustions for fall damage
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA9E95, nop, nop.Length, ref discardRef); //patch instrustions for fire damage
        }

        public void patchSpeed()
        {
            byte[] newSpeedInst = new byte[] { 0xF3, 0x0F, 0x10, 0x81, 0x60, 0x01, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA618a, newSpeedInst, newSpeedInst.Length, ref discardRef); //patch instruction 2
        }

        public void unPatchImmortality()
        {
            byte[] speedFunc = new byte[] { 0xF3, 0x0F, 0x11, 0x81, 0x5C, 0x01, 0x00, 0x00 };
            byte[] priImFunc = new byte[] { 0xF3, 0x0F, 0x11, 0x91, 0x5C, 0x01, 0x00, 0x00 };
            byte[] secImFunc = new byte[] { 0xF3, 0x0F, 0x11, 0x86, 0x5C, 0x01, 0x00, 0x00 };
            byte[] firImFunc = new byte[] { 0xF3, 0x0F, 0x11, 0x87, 0x5C, 0x01, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA6182, speedFunc, speedFunc.Length, ref discardRef); //re-insert instruction 1
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA8CF3, priImFunc, priImFunc.Length, ref discardRef); //unpatch instrustions for basic damage
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA7FB7, secImFunc, secImFunc.Length, ref discardRef); //unpatch instrustions for fall damage
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA9E95, firImFunc, firImFunc.Length, ref discardRef); //unpatch instrustions for fire immortality
        }

        public void unpatchSpeed()
        {
            byte[] oldSpeedInst = new byte[] { 0xF3, 0x0F, 0x10, 0x81, 0x5C, 0x01, 0x00, 0x00 };
            WriteProcessMemory(pack.processHandle, pack.process.MainModule.BaseAddress.ToInt64() + 0xA618a, oldSpeedInst, oldSpeedInst.Length, ref discardRef); //unpatch instruction 2
        }

        public void setCurrentHealth(float health)
        {
            byte[] stronk = BitConverter.GetBytes(health);
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x015C, stronk, stronk.Length, ref discardRef);
        }

        public void setCurrentSpeed(float speed)
        {
            byte[] speedBytes = BitConverter.GetBytes(speed);
            WriteProcessMemory(pack.processHandle, pack.playerInstance + 0x0160, speedBytes, speedBytes.Length, ref discardRef);
        }
    }
}
