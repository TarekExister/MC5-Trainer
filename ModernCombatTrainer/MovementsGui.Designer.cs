
namespace ModernCombatTrainer
{
    partial class MovementsGui
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
            this.lblJump = new System.Windows.Forms.Label();
            this.lblWallHackV1 = new System.Windows.Forms.Label();
            this.lblTpToAimCoords = new System.Windows.Forms.Label();
            this.lblSaveLoadCoords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJump
            // 
            this.lblJump.AutoSize = true;
            this.lblJump.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblJump.Location = new System.Drawing.Point(-1, 26);
            this.lblJump.Name = "lblJump";
            this.lblJump.Size = new System.Drawing.Size(151, 15);
            this.lblJump.TabIndex = 7;
            this.lblJump.Text = "⬤ Jump                                 ";
            // 
            // lblWallHackV1
            // 
            this.lblWallHackV1.AutoSize = true;
            this.lblWallHackV1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallHackV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblWallHackV1.Location = new System.Drawing.Point(-1, 4);
            this.lblWallHackV1.Name = "lblWallHackV1";
            this.lblWallHackV1.Size = new System.Drawing.Size(155, 15);
            this.lblWallHackV1.TabIndex = 6;
            this.lblWallHackV1.Text = "⬤ Wall Hack V1                   ";
            // 
            // lblTpToAimCoords
            // 
            this.lblTpToAimCoords.AutoSize = true;
            this.lblTpToAimCoords.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpToAimCoords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblTpToAimCoords.Location = new System.Drawing.Point(-1, 70);
            this.lblTpToAimCoords.Name = "lblTpToAimCoords";
            this.lblTpToAimCoords.Size = new System.Drawing.Size(228, 15);
            this.lblTpToAimCoords.TabIndex = 9;
            this.lblTpToAimCoords.Text = "⬤ Tp To Aim Coords                                 ";
            // 
            // lblSaveLoadCoords
            // 
            this.lblSaveLoadCoords.AutoSize = true;
            this.lblSaveLoadCoords.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveLoadCoords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.lblSaveLoadCoords.Location = new System.Drawing.Point(-1, 48);
            this.lblSaveLoadCoords.Name = "lblSaveLoadCoords";
            this.lblSaveLoadCoords.Size = new System.Drawing.Size(185, 15);
            this.lblSaveLoadCoords.TabIndex = 8;
            this.lblSaveLoadCoords.Text = "⬤ Save/Load Coords                  ";
            // 
            // MovementsGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(150, 89);
            this.ControlBox = false;
            this.Controls.Add(this.lblTpToAimCoords);
            this.Controls.Add(this.lblSaveLoadCoords);
            this.Controls.Add(this.lblJump);
            this.Controls.Add(this.lblWallHackV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovementsGui";
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

        private System.Windows.Forms.Label lblJump;
        private System.Windows.Forms.Label lblWallHackV1;
        private System.Windows.Forms.Label lblTpToAimCoords;
        private System.Windows.Forms.Label lblSaveLoadCoords;
    }
}