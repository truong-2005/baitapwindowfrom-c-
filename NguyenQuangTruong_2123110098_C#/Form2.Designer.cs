namespace Example01
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TextBox for Name
            this.tbName.Location = new System.Drawing.Point(100, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 0;

            // RadioButtons for Gender
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(100, 100);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;

            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(200, 100);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(41, 17);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;

            // CheckBox for Discount
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(100, 150);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(65, 17);
            this.ckDiscount.TabIndex = 3;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;

            // TextBox for Result
            // TextBox for Result
            this.tbResult.Location = new System.Drawing.Point(100, 200); // Đặt vị trí của TextBox trên form
            this.tbResult.Name = "tbResult"; // Tên TextBox để dễ dàng truy cập trong code
            this.tbResult.Size = new System.Drawing.Size(200, 20); // Kích thước của TextBox
            this.tbResult.TabIndex = 4; // Chỉ số Tab để người dùng di chuyển giữa các điều khiển
            this.tbResult.ReadOnly = true; // Đảm bảo TextBox chỉ có thể đọc, không thể sửa


            // Calculate Button
            this.btCalculate.Location = new System.Drawing.Point(100, 250);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "Tính tiền";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);

            // Exit Button
            this.btExit.Location = new System.Drawing.Point(200, 250);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // Form1 properties
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Quản lý khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btExit;
    }
}
