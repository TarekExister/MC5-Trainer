using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCombatTrainer
{
    public partial class MovementsGui : Form
    {
        public MovementsGui(ref Label[]labels)
        {
            InitializeComponent();
            IntPtr initialStyle = WindowsAPI.User32.GetWindowLong(this.Handle, -20);
            WindowsAPI.User32.SetWindowLong32(this.Handle, -20, (int)initialStyle | 0x80000 | 0x20);
            labels[0] = lblWallHackV1;
            labels[1] = lblJump;
            labels[2] = lblSaveLoadCoords;
            labels[3] = lblTpToAimCoords;
        }
    }
}
