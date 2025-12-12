using System;
using System.Windows.Forms;

namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Thêm"
        private void btAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string birthDate = dtpBirthDate.Value.ToShortDateString();
            string gender = rbMale.Checked ? "Nam" : "Nữ";
            string faculty = cbFaculty.SelectedItem?.ToString();

            // Kiểm tra nếu tất cả trường đã nhập
            if (!string.IsNullOrEmpty(name) && faculty != null)
            {
                string studentInfo = $"{lbStudents.Items.Count + 1}. {name}\r\n- Giới tính: {gender}\r\n- Ngày sinh: {birthDate}\r\n- Khoa: {faculty}";
                lbStudents.Items.Add(studentInfo); // Thêm sinh viên vào ListBox
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Thoát"
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng
        }
    }
}
