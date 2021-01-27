using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Movements
{
    public static class TpToAimCoords
    {
        private static byte[] SavedCoords = new byte[12];
        private static void Loop()
        {
            while (true)
            {
                if (WindowsAPI.User32.GetAsyncKeyState(Keys.F2) != 0)
                {
                    while (WindowsAPI.User32.GetAsyncKeyState(Keys.F2) != 0) ;
                    SavedCoords = MC5Memory.Mc5Mem.ReadBytes(MC5Memory.GameMemory.AimCoordinates.XAddress, 12);
                    Thread.Sleep(10);
                    MC5Memory.Mc5Mem.WriteBytes(MC5Memory.GameMemory.Coordinates.XAddress, SavedCoords, 12);
                    Thread.Sleep(100);
                }
                Thread.Sleep(200);
            }
        }
        private static bool IsRunning = false;
        private static Thread TpToAimCoordsThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    TpToAimCoordsThread = new Thread(Loop);
                    TpToAimCoordsThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                TpToAimCoordsThread.Abort();
            }
        }
    }
}
