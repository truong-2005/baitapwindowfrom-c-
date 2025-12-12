using System;
using System.Windows.Forms;

namespace Example03
{
    // Đảm bảo lớp Form3 là partial, sử dụng từ khóa partial cho các phần khai báo khác nhau
    public partial class Form3 : Form
    {
        // Constructor của Form3
        public Form3()
        {
            InitializeComponent(); // Gọi phương thức tự động sinh ra để khởi tạo các điều khiển của Form
        }
    }
}
