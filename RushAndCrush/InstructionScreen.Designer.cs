namespace RushAndCrush
{
    partial class InstructionScreen
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
            this.instructions = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.instructionLabel.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(0, 88);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(1500, 123);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "HOW TO PLAY";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Snow;
            this.instructions.Location = new System.Drawing.Point(165, 284);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(1184, 750);
            this.instructions.TabIndex = 2;
            this.instructions.Text = "\r\n";
            // 
            // commandLabel
            // 
            this.commandLabel.BackColor = System.Drawing.Color.DarkRed;
            this.commandLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.commandLabel.Location = new System.Drawing.Point(165, 1034);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(1184, 128);
            this.commandLabel.TabIndex = 3;
            this.commandLabel.Text = "\r\nPress Enter to go to Play, Press Escape to Exit\r\n\r\n\r\n";
            this.commandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.instructionLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1500, 1200);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InstructionScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label commandLabel;
    }
}
