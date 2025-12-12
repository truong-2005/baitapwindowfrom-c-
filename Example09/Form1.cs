using System;
using System.Windows.Forms;

namespace Example09
{
    public partial class Form1 : Form
    {
        int seconds = 0; // tổng số giây

        public Form1()
        {
            InitializeComponent();
        }

        // Bấm Start
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Bấm Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // Mỗi giây chạy 1 lần
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            int minute = seconds / 60;
            int second = seconds % 60;

            lblTime.Text = minute.ToString("00") + ":" + second.ToString("00");
        }
    }
}
