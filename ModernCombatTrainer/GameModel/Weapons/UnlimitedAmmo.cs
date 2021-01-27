using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModernCombatTrainer.GameModel.Weapons
{
    public static class UnlimitedAmmo
    {
        private static void Loop()
        {
            int CurrentAmmo1 = MC5Memory.Mc5Mem.Read<int>(MC5Memory.GameMemory.Ammo1.Address);
            int CurrentAmmo2 = MC5Memory.Mc5Mem.Read<int>(MC5Memory.GameMemory.Ammo2.Address);
            while (true)
            {
                MC5Memory.Mc5Mem.Write<int>(MC5Memory.GameMemory.Ammo1.Address, CurrentAmmo1);
                MC5Memory.Mc5Mem.Write<int>(MC5Memory.GameMemory.Ammo2.Address, CurrentAmmo2);
                Thread.Sleep(10);
            }
        }

        private static bool IsRunning = false;
        private static Thread UnlimitedAmmoThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    UnlimitedAmmoThread = new Thread(Loop);
                    UnlimitedAmmoThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                UnlimitedAmmoThread.Abort();
            }
        }
    }
}
