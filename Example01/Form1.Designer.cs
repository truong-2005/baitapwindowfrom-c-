namespace Example01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btOK;

        private void InitializeComponent()
        {
            cb_Faculty = new ComboBox();
            tbName = new TextBox();
            btOK = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Location = new Point(30, 50);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(121, 28);
            cb_Faculty.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(30, 90);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 27);
            tbName.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(30, 130);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 2;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(cb_Faculty);
            Controls.Add(tbName);
            Controls.Add(btOK);
            Name = "Form1";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
