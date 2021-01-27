using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.GameModel.Movements
{
    public static class WallHackV1
    {
        private static void Loop()
        {
            while (true)
            {
                while (WindowsAPI.User32.GetAsyncKeyState(Keys.Space) != 0)
                {
                    float x, y;
                    float CameraRoll = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.CameraRoll.Address);
                    if ((CameraRoll < 30.0f) || (CameraRoll > 320.0f))
                    {
                        y = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Coordinates.YAddress);
                        Thread.Sleep(10);
                        MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Coordinates.YAddress, y + 1.0f);
                    }
                    else if ((CameraRoll < 320.0f) && (CameraRoll > 230.0f))
                    {
                        x = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Coordinates.XAddress);
                        Thread.Sleep(10);
                        MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Coordinates.XAddress, x + 1.0f);
                    }
                    else if ((CameraRoll < 230.0f) && (CameraRoll > 130.0f))
                    {
                        y = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Coordinates.YAddress);
                        Thread.Sleep(10);
                        MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Coordinates.YAddress, y - 1.0f);
                    }
                    else
                    {
                        x = MC5Memory.Mc5Mem.Read<float>(MC5Memory.GameMemory.Coordinates.XAddress);
                        Thread.Sleep(10);
                        MC5Memory.Mc5Mem.Write<float>(MC5Memory.GameMemory.Coordinates.XAddress, x - 1.0f);
                    }

                    Thread.Sleep(100);
                }
                Thread.Sleep(200);
            }
        }

        private static bool IsRunning = false;
        private static Thread WallHackThread;

        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    WallHackThread = new Thread(Loop);
                    WallHackThread.Start();
                }
            }
        }
        public static void Disable()
        {
            if (IsRunning)
            {
                IsRunning = false;
                WallHackThread.Abort();
            }
        }
    }
}
