using System;
using System.Windows.Forms;

namespace Example05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSongs();
        }

        private void LoadSongs()
        {
            lstAllSongs.Items.Add("Gi?c m? Chapi");
            lstAllSongs.Items.Add("?ôi M?t Pleiku");
            lstAllSongs.Items.Add("Em Mu?n S?ng Bên Anh Tr?n ??i");
            lstAllSongs.Items.Add("H'Zen Lên R?y");
            lstAllSongs.Items.Add("Còn Th??ng Nhau Thì V? Buôn Mê Thu?t");
            lstAllSongs.Items.Add("Ly Cà Phê Ban Mê");
            lstAllSongs.Items.Add("?i tìm l?i ru m?t tr?i");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAllSongs.SelectedItem != null)
            {
                lstFavorite.Items.Add(lstAllSongs.SelectedItem);
                lstAllSongs.Items.Remove(lstAllSongs.SelectedItem);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstFavorite.SelectedItem != null)
            {
                lstAllSongs.Items.Add(lstFavorite.SelectedItem);
                lstFavorite.Items.Remove(lstFavorite.SelectedItem);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstAllSongs.Items)
                lstFavorite.Items.Add(item);

            lstAllSongs.Items.Clear();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstFavorite.Items)
                lstAllSongs.Items.Add(item);

            lstFavorite.Items.Clear();
        }
    }
}
