using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.MC5Screen
{
    public static class UpdateTrainerLocation
    {
        private static readonly string ProcessName = "WindowsEntryPoint.Windows_W10";

        public static void SetToTopLeft(Form frm) /*SetToTopMiddle()*/
        {
            if (MC5Memory.Mc5Mem.AttachProcess(ProcessName)) 
            {
                WindowsAPI.User32.RECT rec;
                IntPtr handle = MC5Memory.Mc5Mem.GetUWPWindowHandle();
                bool IsRectNull = !WindowsAPI.User32.GetWindowRect(handle, out rec);
                if (!IsRectNull)
                {
                    frm.Invoke(new MethodInvoker(delegate
                     {
                         frm.Top = rec.Top + 44;
                         frm.Left = rec.Left + 15;
                     }));
                }
                
            }
            else
            {
                frm.Invoke(new MethodInvoker(delegate
                {
                    if (MessageBox.Show("Game Not Found!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
                    == DialogResult.Cancel) 
                    {
                        Process CurrentProcess = Process.GetCurrentProcess();
                        CurrentProcess.Kill();
                    }
                }));
            }
        }

    }
}
