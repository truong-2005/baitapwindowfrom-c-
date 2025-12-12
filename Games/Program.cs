using System;
using System.Windows.Forms;

namespace ShadowFight2D
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Khởi chạy Form1 khi ứng dụng bắt đầu
        }
    }
}
