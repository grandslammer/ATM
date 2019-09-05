using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Business_Layer;

namespace ATM.Presentation_Layer
{
    public partial class frmWithdrawal : Form
    {
        public frmWithdrawal()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Visible = true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            double amountToWithddraw = 0;

            if (double.TryParse(txtAmount.Text, out amountToWithddraw))
            {
                if (Bank.CustomerAccount.MakeWithdrawal(amountToWithddraw) == true)
                {
                    MessageBox.Show(amountToWithddraw + " withdrawn. Your new balance is " + Bank.CustomerAccount.Balance);
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Insufficient funds! Try again.");
                    txtAmount.Clear();
                }
            }
            else
                txtAmount.Clear();
        }

        private void FrmWithdrawal_Load(object sender, EventArgs e)
        {
            txtAmount.Focus();
        }
    }
}
