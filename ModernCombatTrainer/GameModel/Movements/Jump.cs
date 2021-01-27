using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Movements
{
    public static class Jump
    {
        private static void JumpLoop() 
        {
            while (true)
            {
                while (WindowsAPI.User32.GetAsyncKeyState(Keys.F1) != 0)
                {
                    MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Coordinates.ZAddress,
                        MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Coordinates.ZAddress) + 1.0f);
                    Thread.Sleep(100);
                }
                Thread.Sleep(200);
            }
        }
        private static bool IsRunning = false;
        private static Thread JumpThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    JumpThread  = new Thread(JumpLoop);
                    JumpThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning) 
            {
                IsRunning = false;
                JumpThread.Abort();
            }
        }
    }
}
