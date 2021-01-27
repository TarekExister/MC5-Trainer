using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ModernCombatTrainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IntPtr initialStyle = WindowsAPI.User32.GetWindowLong(this.Handle, -20);
            WindowsAPI.User32.SetWindowLong32(this.Handle, -20, (int)initialStyle | 0x80000 | 0x20);
        }

        public Label[] pgLbls = new Label[2];
        public Label[] wgLbls = new Label[2];
        public Label[] mgLbls = new Label[4];

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            TrainerSettings.UpdateForm.CurrentFormIndex = 1;

            PlayerGui pg = new PlayerGui(ref pgLbls);
            WeaponGui wg = new WeaponGui(ref wgLbls);
            MovementsGui mg = new MovementsGui(ref mgLbls);

            TrainerSettings.UpdateForm.frm1 = pg;
            TrainerSettings.UpdateForm.frm2 = wg;
            TrainerSettings.UpdateForm.frm3 = mg;

            TrainerSettings.UpdateForm.UpdateLocation(pg, new Point(this.Left + this.Width+1, (this.Top + lblPlayer.Top)-4));
            TrainerSettings.UpdateForm.UpdateLocation(wg, new Point(this.Left + this.Width + 1, (this.Top + lblWeapons.Top) - 4));
            TrainerSettings.UpdateForm.UpdateLocation(mg, new Point(this.Left + this.Width + 1, (this.Top + lblMovements.Top) - 4));

            pg.Show();
            wg.Show();
            mg.Show();

            pg.Visible = false;
            wg.Visible = false;
            mg.Visible = false;

            this.LocationChanged += delegate 
            {
                TrainerSettings.UpdateForm.UpdateLocation(TrainerSettings.UpdateForm.frm1, new Point(this.Left + this.Width + 1, (this.Top + lblPlayer.Top) - 4));
                TrainerSettings.UpdateForm.UpdateLocation(TrainerSettings.UpdateForm.frm2, new Point(this.Left + this.Width + 1, (this.Top + lblWeapons.Top) - 4));
                TrainerSettings.UpdateForm.UpdateLocation(TrainerSettings.UpdateForm.frm3, new Point(this.Left + this.Width + 1, (this.Top + lblMovements.Top) - 4));
            };

            bgKeysState.RunWorkerAsync();

        }

        private void bgKeysState_DoWork(object sender, DoWorkEventArgs e)
        {
            Label[] Frm1labels = {lblPlayer,lblWeapons,lblMovements };
            Label[] Frm2labels = { pgLbls[0],pgLbls[1]};
            Label[] Frm3labels = { wgLbls[0], wgLbls[1] };
            Label[] Frm4labels = { mgLbls[0], mgLbls[1] , mgLbls[2], mgLbls[3] };

            Label[][] AllLabels = {Frm1labels,Frm2labels, Frm3labels,Frm4labels };
            while (true) 
            {
                MC5Screen.UpdateTrainerLocation.SetToTopLeft(this);
                TrainerSettings.KeysEvents.SetLabelsKeys(AllLabels[TrainerSettings.UpdateForm.CurrentFormIndex-1], Keys.Down,TrainerSettings.UpdateForm.CurrentFormIndex);
                TrainerSettings.KeysEvents.SetLabelsKeys(AllLabels[TrainerSettings.UpdateForm.CurrentFormIndex-1], Keys.Up, TrainerSettings.UpdateForm.CurrentFormIndex);
                TrainerSettings.KeysEvents.UpdateLeftAndRightArrow(AllLabels[TrainerSettings.UpdateForm.CurrentFormIndex-1], Keys.Right);
                TrainerSettings.KeysEvents.UpdateLeftAndRightArrow(AllLabels[TrainerSettings.UpdateForm.CurrentFormIndex-1], Keys.Left);
            }
        }
    }
}
