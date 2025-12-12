using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Event handler for the "Tính tiền" button click
        private void btCalculate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string gender = rbMale.Checked ? "Ông" : "Bà";
            string discountMessage = " không được giảm.";

            // Check if discount is selected
            if (ckDiscount.Checked)
            {
                discountMessage = " được giảm 7%.";
            }

            // Display the result in tbResult
            tbResult.Text = $"{gender} {name}{discountMessage}";
        }

        // Event handler for the "Thoát" button click
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}
