namespace Example03
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        // Phương thức Dispose để giải phóng tài nguyên không cần thiết
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Phương thức tự động sinh ra để khởi tạo các điều khiển của Form
        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();

            // Cấu hình DateTimePicker
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short; // Hiển thị theo định dạng ngắn
            this.dtpDate.Location = new System.Drawing.Point(100, 50); // Vị trí
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20); // Kích thước
            this.dtpDate.TabIndex = 0;

            // Cấu hình Form
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.dtpDate); // Thêm DateTimePicker vào Form
            this.Name = "Form3";
            this.Text = "Chọn Ngày"; // Tiêu đề Form
            this.ResumeLayout(false);
        }

        // Khai báo DateTimePicker
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
