using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example13
{
    public partial class Form1 : Form
    {
        // ===== GÀ (ẢNH) =====
        Image chickenImg;
        int chickenX = 250, chickenY = 10;
        int chickenW = 90, chickenH = 90;

        // ===== TRỨNG =====
        int eggX, eggY;
        int eggSize = 20;
        int eggSpeed = 4;
        bool isBroken = false;
        int brokenCounter = 0;

        // ===== THÙNG RÁC =====
        int trashX = 260, trashY = 330;
        int trashW = 60, trashH = 40;
        int step = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Load ảnh gà (file phải có trong thư mục exe)
            chickenImg = Image.FromFile("chicken.png");

            ResetEgg();
            timer1.Start();
        }

        void ResetEgg()
        {
            eggX = chickenX + chickenW / 2 - eggSize / 2;
            eggY = chickenY + chickenH;
            isBroken = false;
            brokenCounter = 0;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isBroken)
            {
                eggY += eggSpeed;

                Rectangle eggRect = new Rectangle(eggX, eggY, eggSize, eggSize);
                Rectangle trashRect = new Rectangle(trashX, trashY, trashW, trashH);

                // HỨNG → KHÔNG BỂ
                if (eggRect.IntersectsWith(trashRect))
                {
                    ResetEgg();
                    return;
                }

                // KHÔNG HỨNG → CHẠM ĐÁY → BỂ
                if (eggY > ClientSize.Height - eggSize)
                {
                    isBroken = true;
                    brokenCounter = 0;
                }
            }
            else
            {
                brokenCounter++;
                if (brokenCounter > 20)
                    ResetEgg();
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            DrawChicken(g);
            DrawTrash(g);

            if (!isBroken) DrawEgg(g);
            else DrawBrokenEgg(g);
        }

        // ===== VẼ =====
        void DrawChicken(Graphics g)
        {
            g.DrawImage(chickenImg, chickenX, chickenY, chickenW, chickenH);
        }

        void DrawEgg(Graphics g)
        {
            g.FillEllipse(Brushes.Gold, eggX, eggY, eggSize, eggSize + 5);
            g.DrawEllipse(Pens.Black, eggX, eggY, eggSize, eggSize + 5);
        }

        void DrawBrokenEgg(Graphics g)
        {
            g.FillPie(Brushes.Gold, eggX - 10, eggY, eggSize, eggSize, 0, 180);
            g.FillPie(Brushes.Gold, eggX + 10, eggY, eggSize, eggSize, 0, 180);
        }

        void DrawTrash(Graphics g)
        {
            // Nắp
            g.FillRectangle(Brushes.DarkGray, trashX - 6, trashY - 10, trashW + 12, 10);
            g.DrawRectangle(Pens.Black, trashX - 6, trashY - 10, trashW + 12, 10);

            // Thân
            g.FillRectangle(Brushes.LightGray, trashX, trashY, trashW, trashH);
            g.DrawRectangle(Pens.Black, trashX, trashY, trashW, trashH);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) trashX -= step;
            if (e.KeyCode == Keys.Right) trashX += step;
            if (e.KeyCode == Keys.Up) trashY -= step;
            if (e.KeyCode == Keys.Down) trashY += step;

            // Giới hạn trong form
            if (trashX < 0) trashX = 0;
            if (trashY < 0) trashY = 0;
            if (trashX + trashW > ClientSize.Width)
                trashX = ClientSize.Width - trashW;
            if (trashY + trashH > ClientSize.Height)
                trashY = ClientSize.Height - trashH;

            Invalidate();
        }
    }
}
