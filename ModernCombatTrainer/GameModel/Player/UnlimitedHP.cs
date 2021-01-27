using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Player
{
    public static class UnlimitedHP
    {

        private static void Loop()
        {
            float CurrentHp = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Health.Address);

            while (true)
            {
                MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Health.Address, CurrentHp);
                Thread.Sleep(20);
            }
        }

        private static bool IsRunning = false;
        private static Thread HPThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    HPThread = new Thread(Loop);
                    HPThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                HPThread.Abort();
            }
        }
    }
}
