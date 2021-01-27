
namespace ModernCombatTrainer
{
    partial class WeaponGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnlimitedVPower = new System.Windows.Forms.Label();
            this.lblUnlimitedAmmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnlimitedVPower
            // 
            this.lblUnlimitedVPower.AutoSize = true;
            this.lblUnlimitedVPower.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlimitedVPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblUnlimitedVPower.Location = new System.Drawing.Point(-1, 4);
            this.lblUnlimitedVPower.Name = "lblUnlimitedVPower";
            this.lblUnlimitedVPower.Size = new System.Drawing.Size(171, 15);
            this.lblUnlimitedVPower.TabIndex = 5;
            this.lblUnlimitedVPower.Text = "⬤ Unlimited V.Power            ";
            // 
            // lblUnlimitedAmmo
            // 
            this.lblUnlimitedAmmo.AutoSize = true;
            this.lblUnlimitedAmmo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlimitedAmmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblUnlimitedAmmo.Location = new System.Drawing.Point(-1, 26);
            this.lblUnlimitedAmmo.Name = "lblUnlimitedAmmo";
            this.lblUnlimitedAmmo.Size = new System.Drawing.Size(155, 15);
            this.lblUnlimitedAmmo.TabIndex = 6;
            this.lblUnlimitedAmmo.Text = "⬤ Unlimited Ammo          ";
            // 
            // WeaponGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(150, 49);
            this.ControlBox = false;
            this.Controls.Add(this.lblUnlimitedAmmo);
            this.Controls.Add(this.lblUnlimitedVPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponGui";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnlimitedVPower;
        private System.Windows.Forms.Label lblUnlimitedAmmo;
    }
}