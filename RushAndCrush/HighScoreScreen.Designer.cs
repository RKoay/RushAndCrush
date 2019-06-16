namespace RushAndCrush
{
    partial class HighScoreScreen
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.highScores = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.instructionLabel.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(0, 71);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(1500, 123);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "HIGH SCORES";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores
            // 
            this.highScores.BackColor = System.Drawing.Color.White;
            this.highScores.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores.Location = new System.Drawing.Point(531, 238);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(450, 847);
            this.highScores.TabIndex = 3;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instruction.Location = new System.Drawing.Point(451, 1109);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(609, 70);
            this.instruction.TabIndex = 4;
            this.instruction.Text = "Press Enter To Go Back";
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.highScores);
            this.Controls.Add(this.instructionLabel);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(1500, 1200);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HighScoreScreen_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HighScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label highScores;
        private System.Windows.Forms.Label instruction;
    }
}
