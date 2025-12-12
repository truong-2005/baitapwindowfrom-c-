namespace ShadowFight2D
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox txtStatus;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.character = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();

            // character
            this.character.Location = new System.Drawing.Point(100, 300);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(100, 150);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // lblHealth
            this.lblHealth.Location = new System.Drawing.Point(10, 10);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(100, 30);
            this.lblHealth.Text = "Health: 100";
            this.lblHealth.ForeColor = System.Drawing.Color.White;

            // txtStatus
            this.txtStatus.Location = new System.Drawing.Point(10, 50);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(250, 30);
            this.txtStatus.Multiline = true;
            this.txtStatus.Enabled = false;

            // gameTimer
            this.gameTimer.Interval = 1000 / 60; // 60 FPS
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            this.gameTimer.Start();

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.character);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtStatus);
            this.Name = "Form1";
            this.Text = "Shadow Fight Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
