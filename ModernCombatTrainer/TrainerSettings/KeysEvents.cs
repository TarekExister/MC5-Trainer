using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.TrainerSettings
{
    public static class KeysEvents
    {
        public static void SetLabelsKeys(Label [] labels,Keys _key , int FormIndex) 
        {
            if (WindowsAPI.User32.GetAsyncKeyState(_key) != 0)
            {
                while (WindowsAPI.User32.GetAsyncKeyState(_key) != 0) ;
               TrainerUi.ControlSetting.GetKeyAndSetLabelColor(labels, _key , FormIndex);
            }
        }

        public static void UpdateLeftAndRightArrow(Label[] _lbl,Keys _key) 
        {
            if (WindowsAPI.User32.GetAsyncKeyState(_key) != 0)
            {
                while (WindowsAPI.User32.GetAsyncKeyState(_key) != 0) ;
                if (TrainerSettings.UpdateForm.CurrentFormIndex == 1)
                {
                    foreach (Label lbl in _lbl)
                    {
                        if ((_key == Keys.Right) && (lbl.Name == "lblPlayer") && (lbl.ForeColor == Color.White))
                        {
                            TrainerSettings.SwitchBetweenForms.OpenThisForm("PlayerGui");
                            TrainerSettings.UpdateForm.CurrentFormIndex = 2;
                        }
                        if ((_key == Keys.Right) && (lbl.Name == "lblWeapons") && (lbl.ForeColor == Color.White))
                        {
                            TrainerSettings.SwitchBetweenForms.OpenThisForm("WeaponGui");
                            TrainerSettings.UpdateForm.CurrentFormIndex = 3;
                        }
                        if ((_key == Keys.Right) && (lbl.Name == "lblMovements") && (lbl.ForeColor == Color.White))
                        {
                            TrainerSettings.SwitchBetweenForms.OpenThisForm("MovementsGui");
                            TrainerSettings.UpdateForm.CurrentFormIndex = 4;
                        }
                        if (_key == Keys.Left)
                        {
                            TrainerSettings.SwitchBetweenForms.CloseAllForms();
                        }
                    }
                }

                if (TrainerSettings.UpdateForm.CurrentFormIndex == 2)
                {
                    foreach (Label lbl in _lbl)
                    {

                        if (_key == Keys.Right)
                        {
                            if (lbl.BackColor == Color.FromArgb(203, 8, 8))
                            {
                                switch (lbl.Name) 
                                {
                                    case "lblUnlimitedHp":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Player.UnlimitedHP.Enable();
                                        }
                                        else 
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Player.UnlimitedHP.Disable();
                                        }
                                        break;
                                    case "lblAutoShoot":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Player.AutoShoot.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Player.AutoShoot.Disable();
                                        }
                                        break;
                                }
                            }

                        }

                        if (_key == Keys.Left)
                        {
                            TrainerSettings.SwitchBetweenForms.CloseAllForms();
                            lbl.BackColor = Color.FromArgb(16, 16, 16);
                            if (lbl.ForeColor != Color.Gold)
                                lbl.ForeColor = Color.FromArgb(140, 19, 15);
                            TrainerUi.ControlSetting.CurrentIndexFrm2 = 0;
                        }
                    }
                }

                else if (TrainerSettings.UpdateForm.CurrentFormIndex == 3)
                {
                    foreach (Label lbl in _lbl)
                    {
                        if (_key == Keys.Right)
                        {
                            if (lbl.BackColor == Color.FromArgb(203, 8, 8))
                            {
                                switch (lbl.Name)
                                {
                                    case "lblUnlimitedVPower":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Weapons.UnlimitedVerrPower.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Weapons.UnlimitedVerrPower.Disable();
                                        }
                                        break;
                                    case "lblUnlimitedAmmo":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Weapons.UnlimitedAmmo.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Weapons.UnlimitedAmmo.Disable();
                                        }
                                        break;
                                }
                            }
                        }
                        if (_key == Keys.Left)
                        {
                            TrainerSettings.SwitchBetweenForms.CloseAllForms();
                            lbl.BackColor = Color.FromArgb(16, 16, 16);
                            if (lbl.ForeColor != Color.Gold)
                                lbl.ForeColor = Color.FromArgb(140, 19, 15);
                            TrainerUi.ControlSetting.CurrentIndexFrm3 = 0;
                        }
                    }
                }

                else if (TrainerSettings.UpdateForm.CurrentFormIndex == 4)
                {
                    foreach (Label lbl in _lbl)
                    {
                        if (_key == Keys.Right)
                        {
                            if (lbl.BackColor == Color.FromArgb(203, 8, 8))
                            {
                                switch (lbl.Name)
                                {
                                    case "lblWallHackV1":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Movements.WallHackV1.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Movements.WallHackV1.Disable();
                                        }
                                        break;
                                    case "lblJump":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Movements.Jump.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Movements.Jump.Disable();
                                        }
                                        break;
                                    case "lblSaveLoadCoords":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Movements.SaveLoadCoords.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Movements.SaveLoadCoords.Disable();
                                        }
                                        break;
                                    case "lblTpToAimCoords":
                                        if (lbl.ForeColor == Color.White)
                                        {
                                            lbl.ForeColor = Color.Gold;
                                            GameModel.Movements.TpToAimCoords.Enable();
                                        }
                                        else
                                        {
                                            lbl.ForeColor = Color.White;
                                            GameModel.Movements.TpToAimCoords.Disable();
                                        }
                                        break;
                                }
                            }
                        }
                        if (_key == Keys.Left)
                        {
                            TrainerSettings.SwitchBetweenForms.CloseAllForms();
                            lbl.BackColor = Color.FromArgb(16, 16, 16);
                            if (lbl.ForeColor != Color.Gold)
                                lbl.ForeColor = Color.FromArgb(140, 19, 15);
                            TrainerUi.ControlSetting.CurrentIndexFrm4 = 0;
                        }
                    }
                }

            }
        }

    }
}
