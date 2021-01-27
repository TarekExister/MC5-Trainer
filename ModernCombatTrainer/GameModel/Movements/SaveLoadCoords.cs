using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Movements
{
    public static class SaveLoadCoords
    {
        private static bool IsEmpty = true;
        private static byte[] SavedCoords = new byte[12];
        private static void Loop()
        {
            while (true)
            {
                if (WindowsAPI.User32.GetAsyncKeyState(Keys.F3) != 0)
                {
                    while (WindowsAPI.User32.GetAsyncKeyState(Keys.F3) != 0) ;
                    SavedCoords = MC5Memory.Mc5Mem.ReadBytes(MC5Memory.GameMemory.Coordinates.XAddress, 12);
                    IsEmpty = false;
                    Thread.Sleep(100);
                }
                if (WindowsAPI.User32.GetAsyncKeyState(Keys.F4) != 0)
                {
                    while (WindowsAPI.User32.GetAsyncKeyState(Keys.F4) != 0) ;
                    if (!IsEmpty)
                    {
                        MC5Memory.Mc5Mem.WriteBytes(MC5Memory.GameMemory.Coordinates.XAddress, SavedCoords, 12);
                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(200);
            }
        }
        private static bool IsRunning = false;
        private static Thread SaveLoadCoordsThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    SaveLoadCoordsThread = new Thread(Loop);
                    SaveLoadCoordsThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                SaveLoadCoordsThread.Abort();
            }
        }
    }
}
