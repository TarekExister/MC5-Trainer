using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.TrainerSettings
{
    public static class UpdateForm
    {
        public static int CurrentFormIndex = 1;
        public static Form frm1;
        public static Form frm2;
        public static Form frm3;
        public static void UpdateLocation(Form frm, Point Location)
        {
            frm.Top = Location.Y;
            frm.Left = Location.X;
        }

    }

}
