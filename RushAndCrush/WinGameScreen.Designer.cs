namespace RushAndCrush
{
    partial class WinGameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinGameScreen));
            this.wingameLabel = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.victoryBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.victoryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wingameLabel
            // 
            this.wingameLabel.AutoSize = true;
            this.wingameLabel.BackColor = System.Drawing.Color.LightCyan;
            this.wingameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wingameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wingameLabel.Location = new System.Drawing.Point(417, 267);
            this.wingameLabel.Name = "wingameLabel";
            this.wingameLabel.Size = new System.Drawing.Size(661, 181);
            this.wingameLabel.TabIndex = 1;
            this.wingameLabel.Text = "You Win !";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.BackColor = System.Drawing.Color.GhostWhite;
            this.instruction.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.instruction.Location = new System.Drawing.Point(424, 628);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(674, 81);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Press enter to continue";
            // 
            // victoryBox
            // 
            this.victoryBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("victoryBox.ErrorImage")));
            this.victoryBox.Image = ((System.Drawing.Image)(resources.GetObject("victoryBox.Image")));
            this.victoryBox.Location = new System.Drawing.Point(3, 0);
            this.victoryBox.Name = "victoryBox";
            this.victoryBox.Size = new System.Drawing.Size(1497, 1200);
            this.victoryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victoryBox.TabIndex = 4;
            this.victoryBox.TabStop = false;
            // 
            // WinGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.wingameLabel);
            this.Controls.Add(this.victoryBox);
            this.Name = "WinGameScreen";
            this.Size = new System.Drawing.Size(1500, 1200);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WinGameScreen_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WinGameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.victoryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wingameLabel;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox victoryBox;
    }
}
