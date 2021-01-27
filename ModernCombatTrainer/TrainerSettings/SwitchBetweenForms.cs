using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer.TrainerSettings
{
    public static class SwitchBetweenForms
    {
        public static void OpenThisForm(string FormName)
        {
            switch (FormName)
            {
                case "PlayerGui":
                    Application.OpenForms["PlayerGui"].Invoke(new MethodInvoker(delegate
                    {
                        Application.OpenForms["PlayerGui"].Visible = true;
                        Application.OpenForms["WeaponGui"].Visible = false;
                        Application.OpenForms["MovementsGui"].Visible = false;
                    })); 
                    TrainerSettings.UpdateForm.CurrentFormIndex = 2;
                    break;
                case "WeaponGui":
                    Application.OpenForms["WeaponGui"].Invoke(new MethodInvoker(delegate
                    {
                        Application.OpenForms["PlayerGui"].Visible = false;
                        Application.OpenForms["WeaponGui"].Visible = true;
                        Application.OpenForms["MovementsGui"].Visible = false;
                    }));
                    TrainerSettings.UpdateForm.CurrentFormIndex = 3;
                    break;
                case "MovementsGui":
                    Application.OpenForms["MovementsGui"].Invoke(new MethodInvoker(delegate
                    {
                        Application.OpenForms["PlayerGui"].Visible = false;
                        Application.OpenForms["WeaponGui"].Visible = false;
                        Application.OpenForms["MovementsGui"].Visible = true;
                    }));
                    TrainerSettings.UpdateForm.CurrentFormIndex = 4;
                    break;
            }
        }


        public static void CloseAllForms()
        {
            Application.OpenForms["PlayerGui"].Invoke(new MethodInvoker(delegate
            {
                Application.OpenForms["PlayerGui"].Visible = false;
                Application.OpenForms["WeaponGui"].Visible = false;
                Application.OpenForms["MovementsGui"].Visible = false;
            }));
            TrainerSettings.UpdateForm.CurrentFormIndex = 1;
        }

    }
}
