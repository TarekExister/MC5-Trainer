using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.TrainerSettings
{
    public static class FrmCloseEvent
    {
        public static void KillProc(Form frm)
        {
            frm.FormClosing += delegate
            {
                Process CurrentProcess = Process.GetCurrentProcess();
                CurrentProcess.Kill();
            };
        }
    }
}