using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example10
{
    public partial class Form1 : Form
    {
        // Tọa độ quả bóng
        int x = 100;
        int y = 100;

        // Kích thước bóng
        int size = 50;

        // Hướng di chuyển
        int dx = 5;
        int dy = 5;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // chống giật hình
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // bắt đầu game
        }

        // VẼ QUẢ BÓNG
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Brush brush = Brushes.Green;
            g.FillEllipse(brush, x, y, size, size);
        }

        // MỖI LẦN TIMER CHẠY
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += dx;
            y += dy;

            // ĐỤNG TƯỜNG TRÁI / PHẢI
            if (x <= 0 || x + size >= this.ClientSize.Width)
                dx = -dx;

            // ĐỤNG TƯỜNG TRÊN / DƯỚI
            if (y <= 0 || y + size >= this.ClientSize.Height)
                dy = -dy;

            Invalidate(); // vẽ lại form
        }
    }
}
