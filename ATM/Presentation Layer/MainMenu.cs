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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Bank.SaveChangesToFile(Login.filePath); - original text file version
            Bank.SaveChangesToDB();
            Application.Exit();
        }

        private void BtnViewBalance_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Balance b = new Balance();
            b.Visible = true;
        }

        private void BtnWithdrawal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmWithdrawal w = new frmWithdrawal();
            w.Visible = true;
        }

        private void BtnLodgement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLodgement l = new frmLodgement();
            l.Visible = true;
        }

        private void BtnChangePIN_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmChangePIN cp = new frmChangePIN();
            cp.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //Bank.SaveChangesToFile(Login.filePath); - original text file version
            Bank.SaveChangesToDB();
            this.Hide();
            Login l = new Login();
            l.Visible = true;
        }
    }
}
