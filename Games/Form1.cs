using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ShadowFight2D
{
    public partial class Form1 : Form
    {
        private int characterX = 100;
        private int characterY = 300;
        private int characterSpeed = 10;
        private int health = 100;
        private bool isAttacking = false;

        public Form1()
        {
            InitializeComponent();
            LoadCharacterImage();
        }

        // Hàm này sẽ tải hình ảnh từ tài nguyên nhúng
        private void LoadCharacterImage()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Games.Resources.character.png"; // Đảm bảo tên tài nguyên chính xác

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    this.character.Image = Image.FromStream(stream);
                    this.character.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Image not found in resources.");
                }
            }
        }

        // Hàm xử lý việc vẽ lại và cập nhật trạng thái
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            character.Location = new Point(characterX, characterY);
            lblHealth.Text = "Health: " + health;

            if (isAttacking)
            {
                txtStatus.Text = "Attacking!";
            }
            else
            {
                txtStatus.Text = "";
            }
        }

        // Hàm xử lý di chuyển nhân vật và tấn công
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                characterX -= characterSpeed; // Di chuyển trái
            }
            else if (e.KeyCode == Keys.Right)
            {
                characterX += characterSpeed; // Di chuyển phải
            }
            else if (e.KeyCode == Keys.Up)
            {
                characterY -= characterSpeed; // Di chuyển lên
            }
            else if (e.KeyCode == Keys.Down)
            {
                characterY += characterSpeed; // Di chuyển xuống
            }
            else if (e.KeyCode == Keys.Space)
            {
                Attack(); // Tấn công
            }
        }

        // Hàm xử lý tấn công
        private void Attack()
        {
            isAttacking = true;
            health -= 5; // Giảm sức khỏe khi tấn công
            MessageBox.Show("You attacked! Health reduced.");
        }
    }
}
