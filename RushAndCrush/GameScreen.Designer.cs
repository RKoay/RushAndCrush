namespace RushAndCrush
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.displayLabel = new System.Windows.Forms.Label();
            this.moneyEarned = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(859, 770);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(638, 120);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "Money Earned ";
            // 
            // moneyEarned
            // 
            this.moneyEarned.AutoSize = true;
            this.moneyEarned.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyEarned.Location = new System.Drawing.Point(936, 911);
            this.moneyEarned.Name = "moneyEarned";
            this.moneyEarned.Size = new System.Drawing.Size(418, 159);
            this.moneyEarned.TabIndex = 1;
            this.moneyEarned.Text = "$00.00";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.moneyEarned);
            this.Controls.Add(this.displayLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1500, 1200);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label moneyEarned;
    }
}
