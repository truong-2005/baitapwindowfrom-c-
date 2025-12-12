using System;
using System.Windows.Forms;

namespace Example03
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new Form()); // Chạy Form3 khi ứng dụng bắt đầu
        }
    }
}
