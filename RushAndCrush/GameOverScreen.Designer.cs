namespace RushAndCrush
{
    partial class GameOverScreen
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
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gameoverLabel.Location = new System.Drawing.Point(369, 307);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(765, 181);
            this.gameoverLabel.TabIndex = 0;
            this.gameoverLabel.Text = "Game Over";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.instruction.Location = new System.Drawing.Point(414, 502);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(674, 81);
            this.instruction.TabIndex = 1;
            this.instruction.Text = "Press enter to continue";
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.gameoverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(1500, 1200);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOverScreen_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameOverScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label instruction;
    }
}
