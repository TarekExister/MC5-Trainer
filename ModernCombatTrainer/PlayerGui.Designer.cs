
namespace ModernCombatTrainer
{
    partial class PlayerGui
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
            this.lblAutoShoot = new System.Windows.Forms.Label();
            this.lblUnlimitedHp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAutoShoot
            // 
            this.lblAutoShoot.AutoSize = true;
            this.lblAutoShoot.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoShoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblAutoShoot.Location = new System.Drawing.Point(-1, 26);
            this.lblAutoShoot.Name = "lblAutoShoot";
            this.lblAutoShoot.Size = new System.Drawing.Size(157, 15);
            this.lblAutoShoot.TabIndex = 5;
            this.lblAutoShoot.Text = "⬤ Auto Shoot                       ";
            // 
            // lblUnlimitedHp
            // 
            this.lblUnlimitedHp.AutoSize = true;
            this.lblUnlimitedHp.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlimitedHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblUnlimitedHp.Location = new System.Drawing.Point(-1, 4);
            this.lblUnlimitedHp.Name = "lblUnlimitedHp";
            this.lblUnlimitedHp.Size = new System.Drawing.Size(160, 15);
            this.lblUnlimitedHp.TabIndex = 4;
            this.lblUnlimitedHp.Text = "⬤ Unlimited HP                   ";
            // 
            // PlayerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(150, 49);
            this.ControlBox = false;
            this.Controls.Add(this.lblAutoShoot);
            this.Controls.Add(this.lblUnlimitedHp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerGui";
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

        private System.Windows.Forms.Label lblAutoShoot;
        private System.Windows.Forms.Label lblUnlimitedHp;
    }
}