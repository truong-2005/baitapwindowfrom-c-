using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example12
{
    public partial class Form1 : Form
    {
        int trashX = 200;
        int trashY = 300;
        int trashWidth = 60;
        int trashHeight = 70;
        int step = 15;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // VẼ THÙNG RÁC
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Nắp thùng
            g.FillRectangle(Brushes.Gray, trashX - 5, trashY - 10, trashWidth + 10, 10);
            g.DrawRectangle(Pens.Black, trashX - 5, trashY - 10, trashWidth + 10, 10);

            // Thân thùng
            g.FillRectangle(Brushes.LightGray, trashX, trashY, trashWidth, trashHeight);
            g.DrawRectangle(Pens.Black, trashX, trashY, trashWidth, trashHeight);

            // Các sọc dọc trên thùng
            int lineCount = 4;
            for (int i = 1; i < lineCount; i++)
            {
                int lx = trashX + i * trashWidth / lineCount;
                g.DrawLine(Pens.DarkGray, lx, trashY, lx, trashY + trashHeight);
            }
        }

        // ĐIỀU KHIỂN BẰNG PHÍM
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                trashX -= step;
            if (e.KeyCode == Keys.Right)
                trashX += step;
            if (e.KeyCode == Keys.Up)
                trashY -= step;
            if (e.KeyCode == Keys.Down)
                trashY += step;

            // KHÔNG RA NGOÀI FORM
            if (trashX < 0) trashX = 0;
            if (trashY < 10) trashY = 10;
            if (trashX + trashWidth > ClientSize.Width)
                trashX = ClientSize.Width - trashWidth;
            if (trashY + trashHeight > ClientSize.Height)
                trashY = ClientSize.Height - trashHeight;

            Invalidate(); // vẽ lại
        }
    }
}
