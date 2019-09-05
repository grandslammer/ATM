using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Presentation_Layer
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Visible = true;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            txtBalance.Text = "€" + Business_Layer.Bank.CustomerAccount.Balance.ToString();
        }
    }
}
