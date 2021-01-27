using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.TrainerUi
{

    public static class ControlSetting
    {
        private static int CurrentIndexFrm1 = 0;
        public static int CurrentIndexFrm2 = 0;
        public static int CurrentIndexFrm3 = 0;
        public static int CurrentIndexFrm4 = 0;

        private static void SetLabelIndexFrm1(Keys _key)
        {
            if ((_key == Keys.Down) && (TrainerSettings.UpdateForm.CurrentFormIndex == 1))
            {
                CurrentIndexFrm1 += 1;
                if (CurrentIndexFrm1 > 3) CurrentIndexFrm1 = 1;
                else if (CurrentIndexFrm1 < 1) CurrentIndexFrm1 = 3;
            }
            else if ((_key == Keys.Up) && (TrainerSettings.UpdateForm.CurrentFormIndex == 1)) 
            {
                if (CurrentIndexFrm1 == 0) CurrentIndexFrm1 = 1;
                else CurrentIndexFrm1 -= 1;
                if (CurrentIndexFrm1 > 3) CurrentIndexFrm1 = 1;
                else if (CurrentIndexFrm1 < 1) CurrentIndexFrm1 = 3;
            }
        }

        private static void SetLabelIndexFrm2(Keys _key)
        {
            if ((_key == Keys.Down) && (TrainerSettings.UpdateForm.CurrentFormIndex == 2))
            {
                CurrentIndexFrm2 += 1;
                if (CurrentIndexFrm2 > 2) CurrentIndexFrm2 = 1;
                else if (CurrentIndexFrm2 < 1) CurrentIndexFrm2 = 2;
            }
            else if ((_key == Keys.Up) && (TrainerSettings.UpdateForm.CurrentFormIndex == 2))
            {
                if (CurrentIndexFrm2 == 0) CurrentIndexFrm2 = 1;
                else CurrentIndexFrm2 -= 1;
                if (CurrentIndexFrm2 > 2) CurrentIndexFrm2 = 1;
                else if (CurrentIndexFrm2 < 1) CurrentIndexFrm2 = 2;
            }
        }
        private static void SetLabelIndexFrm3(Keys _key)
        {
            if ((_key == Keys.Down) && (TrainerSettings.UpdateForm.CurrentFormIndex == 3))
            {
                CurrentIndexFrm3 += 1;
                if (CurrentIndexFrm3 > 2) CurrentIndexFrm3 = 1;
                else if (CurrentIndexFrm3 < 1) CurrentIndexFrm3 = 2;
            }
            else if ((_key == Keys.Up) && (TrainerSettings.UpdateForm.CurrentFormIndex == 3))
            {
                if (CurrentIndexFrm3 == 0) CurrentIndexFrm3 = 1;
                else CurrentIndexFrm3 -= 1;
                if (CurrentIndexFrm3 > 2) CurrentIndexFrm3 = 1;
                else if (CurrentIndexFrm3 < 1) CurrentIndexFrm3 = 2;
            }
        }
        private static void SetLabelIndexFrm4(Keys _key)
        {
            if ((_key == Keys.Down) && (TrainerSettings.UpdateForm.CurrentFormIndex == 4))
            {
                CurrentIndexFrm4 += 1;
                if (CurrentIndexFrm4 > 4) CurrentIndexFrm4 = 1;
                else if (CurrentIndexFrm4 < 1) CurrentIndexFrm4 = 4;
            }
            else if ((_key == Keys.Up) && (TrainerSettings.UpdateForm.CurrentFormIndex == 4))
            {
                if (CurrentIndexFrm4 == 0) CurrentIndexFrm4 = 1;
                else CurrentIndexFrm4 -= 1;
                if (CurrentIndexFrm4 > 4) CurrentIndexFrm4 = 1;
                else if (CurrentIndexFrm4 < 1) CurrentIndexFrm4 = 4;
            }
        }

        private static void SetLabelColorForm1(Label []lbl,Keys _key)
        {
            SetLabelIndexFrm1(_key);
            switch (CurrentIndexFrm1)
            {
                case 1:
                    lbl[0].BackColor = Color.FromArgb(203, 8, 8);
                    lbl[0].ForeColor = Color.White;
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[2].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[2].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 2:
                    lbl[1].BackColor = Color.FromArgb(203, 8, 8);
                    lbl[1].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[2].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[2].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 3:
                    lbl[2].BackColor = Color.FromArgb(203, 8, 8);
                    lbl[2].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
            }
        }

        private static void SetLabelColorForm2(Label[] lbl, Keys _key)
        {
            SetLabelIndexFrm2(_key);
            
            switch (CurrentIndexFrm2)
            {
                case 1:
                    lbl[0].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.White;
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 2:
                    lbl[1].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
            }
        }

        private static void SetLabelColorForm3(Label[] lbl, Keys _key)
        {
            SetLabelIndexFrm3(_key);
            switch (CurrentIndexFrm3)
            {
                case 1:
                    lbl[0].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.White;
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 2:
                    lbl[1].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
            }
        }

        private static void SetLabelColorForm4(Label[] lbl, Keys _key)
        {
            SetLabelIndexFrm4(_key);
            switch (CurrentIndexFrm4)
            {
                case 1:
                    lbl[0].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.White;
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[2].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[2].ForeColor != Color.Gold)
                        lbl[2].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[3].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[3].ForeColor != Color.Gold)
                        lbl[3].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 2:
                    lbl[1].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[2].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[2].ForeColor != Color.Gold)
                        lbl[2].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[3].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[3].ForeColor != Color.Gold)
                        lbl[3].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 3:
                    lbl[2].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[2].ForeColor != Color.Gold)
                        lbl[2].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[3].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[3].ForeColor != Color.Gold)
                        lbl[3].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
                case 4:
                    lbl[3].BackColor = Color.FromArgb(203, 8, 8);
                    if (lbl[3].ForeColor != Color.Gold)
                        lbl[3].ForeColor = Color.White;
                    lbl[0].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[0].ForeColor != Color.Gold)
                        lbl[0].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[1].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[1].ForeColor != Color.Gold)
                        lbl[1].ForeColor = Color.FromArgb(140, 19, 15);
                    lbl[2].BackColor = Color.FromArgb(16, 16, 16);
                    if (lbl[2].ForeColor != Color.Gold)
                        lbl[2].ForeColor = Color.FromArgb(140, 19, 15);
                    break;
            }
        }

        public static void GetKeyAndSetLabelColor(Label[] lbl, Keys _key, int FormIndex) 
        {
            if (FormIndex == 1)
            {
                switch (_key)
                {
                    case Keys.Down:
                        SetLabelColorForm1(lbl, _key);
                        break;
                    case Keys.Up:
                        SetLabelColorForm1(lbl, _key);
                        break;
                }
            }
            else if (FormIndex == 2)
            {
                switch (_key)
                {
                    case Keys.Down:
                        SetLabelColorForm2(lbl, _key);
                        break;
                    case Keys.Up:
                        SetLabelColorForm2(lbl, _key);
                        break;
                }
            }
            else if (FormIndex == 3)
            {
                switch (_key)
                {
                    case Keys.Down:
                        SetLabelColorForm3(lbl, _key);
                        break;
                    case Keys.Up:
                        SetLabelColorForm3(lbl, _key);
                        break;
                }
            }
            else if (FormIndex == 4) 
            {
                switch (_key)
                {
                    case Keys.Down:
                        SetLabelColorForm4(lbl, _key);
                        break;
                    case Keys.Up:
                        SetLabelColorForm4(lbl, _key);
                        break;
                }
            }
        }

    }
}
