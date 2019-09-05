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
    public partial class frmChangePIN : Form
    {
        public frmChangePIN()
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
            string oldPin = txtOldPin.Text;
            string newPin = txtNewPin.Text;
            string confirmPin = txtConfirmNewPin.Text;

            if (oldPin == Bank.CustomerAccount.Pin)
            {
                if (newPin == confirmPin)
                {
                    MessageBox.Show("PIN successfully changed!");
                    Bank.CustomerAccount.Pin = newPin;
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your new PINs do not match! Try again.");
                    txtOldPin.Clear();
                    txtNewPin.Clear();
                    txtConfirmNewPin.Clear();
                }
            }
            else
            {
                MessageBox.Show("Your old PIN does not match your account PIN! Try again.");
                txtOldPin.Clear();
                txtNewPin.Clear();
                txtConfirmNewPin.Clear();
            }
        }

        private void FrmChangePIN_Load(object sender, EventArgs e)
        {
            txtOldPin.Focus();
        }
    }
}
