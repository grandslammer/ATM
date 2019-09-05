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
    public partial class frmLodgement : Form
    {
        public frmLodgement()
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
            double amountToLodge = 0;

            if (double.TryParse(txtAmount.Text, out amountToLodge))
            {
                Bank.CustomerAccount.MakeLodgement(amountToLodge);
                MessageBox.Show(amountToLodge + " lodged. Your new balance is " + Bank.CustomerAccount.Balance);
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Visible = true;
            }
            else
                txtAmount.Clear();
        }

        private void FrmLodgement_Load(object sender, EventArgs e)
        {
            txtAmount.Focus();
        }
    }
}
