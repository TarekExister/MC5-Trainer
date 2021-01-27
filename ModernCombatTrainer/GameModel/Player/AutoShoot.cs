using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Player
{
    public static class AutoShoot
    {
        private static bool CanShoot = false;
        private static void Loop()
        {
            while (true)
            {
                byte Target = MC5Memory.Mc5Mem.Read<byte>(MC5Memory.GameMemory.TargetType.Address);
                if (Target == (byte)MC5Memory.GameMemory.Target.Enemy)
                {
                    MC5Memory.Mc5Mem.Write<byte>(MC5Memory.GameMemory.ShootFlag.Address, 1);
                    CanShoot = true;
                }
                else 
                {
                    if (CanShoot && (Target != (byte)MC5Memory.GameMemory.Target.Enemy)) 
                    {
                        MC5Memory.Mc5Mem.Write<byte>(MC5Memory.GameMemory.ShootFlag.Address, 0);
                        CanShoot = false;
                    }
                }
                Thread.Sleep(10);
            }
        }

        private static bool IsRunning = false;
        private static Thread AutoShootThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    AutoShootThread = new Thread(Loop);
                    AutoShootThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                AutoShootThread.Abort();
            }
        }
    }
}
