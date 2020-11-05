using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeardownMemoryModder
{
    public class offsetPackage
    {
        public Process process { get; set; }
        public IntPtr handle { get; set; }
        public Int64 playerInstance { get; set; }
        public Int64 gameInstance { get; set; }
        public Int32 processHandle { get; set; }
        public Int64 sceneInstance { get; set; }

        public offsetPackage(Process process, IntPtr handle, Int64 playerInstance, Int64 gameInstance, Int32 processHandle, Int64 sceneInstance)
        {
            this.process = process;
            this.handle = handle;
            this.playerInstance = playerInstance;
            this.gameInstance = gameInstance;
            this.processHandle = processHandle;
            this.sceneInstance = sceneInstance;
        }
    }
}
