using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        List<Egg> eggs = new List<Egg>();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.MouseClick += Form1_MouseClick;

            CreateEggs();
            timer1.Start();
        }

        // TẠO NHIỀU TRỨNG
        void CreateEggs()
        {
            eggs.Clear();
            for (int i = 0; i < 5; i++)
            {
                eggs.Add(new Egg(
                    rand.Next(50, this.ClientSize.Width - 50),
                    rand.Next(-200, 0)
                ));
            }
        }

        // TIMER – TRỨNG RƠI
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var egg in eggs)
                egg.Fall(this.ClientSize.Height);

            Invalidate();
        }

        // CLICK CHUỘT ĐẬP TRỨNG
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var egg in eggs)
            {
                if (egg.IsHit(e.Location))
                    egg.Break();
            }
            Invalidate();
        }

        // RESET GAME
        private void btnReset_Click(object sender, EventArgs e)
        {
            CreateEggs();
            timer1.Start();
            Invalidate();
        }

        // VẼ TRỨNG
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var egg in eggs)
                egg.Draw(e.Graphics);
        }
    }

    // =======================
    // CLASS EGG
    // =======================
    class Egg
    {
        int x, y;
        int size = 40;
        int speed = 4;
        bool broken = false;

        public Egg(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Fall(int bottom)
        {
            if (!broken)
            {
                y += speed;
                if (y + size >= bottom)
                    broken = true;
            }
        }

        public void Draw(Graphics g)
        {
            if (!broken)
            {
                g.FillEllipse(Brushes.Gold, x, y, size, size + 10);
                g.DrawEllipse(Pens.Black, x, y, size, size + 10);
            }
            else
            {
                g.FillPie(Brushes.Gold, x - 10, y, size, size, 0, 180);
                g.FillPie(Brushes.Gold, x + 10, y, size, size, 0, 180);
            }
        }

        public bool IsHit(Point p)
        {
            Rectangle rect = new Rectangle(x, y, size, size + 10);
            return rect.Contains(p) && !broken;
        }

        public void Break()
        {
            broken = true;
        }
    }
}
