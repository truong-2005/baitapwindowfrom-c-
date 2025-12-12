using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập dữ liệu cho ComboBox
            cb_Faculty.Items.Add("Công nghệ thông tin");
            cb_Faculty.Items.Add("Quản trị kinh doanh");
            cb_Faculty.Items.Add("Kế toán tài chính");
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị đã chọn từ ComboBox
            string faculty = cb_Faculty.SelectedItem.ToString();
            MessageBox.Show("Bạn đã chọn khoa: " + faculty);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy tên từ TextBox và hiển thị
            string name = tbName.Text;
            MessageBox.Show("Tên của bạn là: " + name);
        }
    }
}
