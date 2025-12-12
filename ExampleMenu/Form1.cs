using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ExampleMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // MỞ EXAMPLE03
        private void btnEx03_Click(object sender, EventArgs e)
        {
            OpenProject("Example04");
        }

        // MỞ EXAMPLE05
        private void btnEx05_Click(object sender, EventArgs e)
        {
            OpenProject("Example05");
        }
                private void button1_Click(object sender, EventArgs e)
        {
            OpenProject("Example04");
        }
        // MỞ EXAMPLE13
        private void btnEx13_Click(object sender, EventArgs e)
        {
            OpenProject("Example13");
        }

        // HÀM DÙNG CHUNG
        void OpenProject(string projectName)
        {
            // đường dẫn tới file exe
            string exePath = Path.Combine(
                Application.StartupPath,
                @"..\..\..\..\" + projectName + @"\bin\Debug\" + projectName + ".exe"
            );

            exePath = Path.GetFullPath(exePath);

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("Chưa build project " + projectName);
            }
        }


    }
}
