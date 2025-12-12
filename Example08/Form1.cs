using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nút chọn ảnh
        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(dlg.FileName);
            }
        }

        // Di chuyển sang trái
        private void btLeft_Click(object sender, EventArgs e)
        {
            picImage.Left -= 20;
        }

        // Di chuyển sang phải
        private void btRight_Click(object sender, EventArgs e)
        {
            picImage.Left += 20;
        }
    }
}
