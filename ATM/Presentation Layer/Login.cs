using ATM.Business_Layer;
using ATM.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public static string filePath = @"C:\Users\Trainee\Desktop\Accounts.txt";

        public Login()
        {
            InitializeComponent();
            //Bank.LoadAccounts(filePath); - original text file version
            Bank.LoadAccountsFromDB();

            foreach (var account in Bank.listOfAccounts)
            {
                txtAccounts.AppendText(account.AccountNb + " | " + account.Pin + "\r\n");
            }
        }

        // Enter button
        private void Button1_Click(object sender, EventArgs e)
        {
            string accountNumInput = txtAccountNumber.Text;
            string pinInput = txtPIN.Text;
            bool successfulLogin = false;

            foreach (var account in Business_Layer.Bank.listOfAccounts)
            {
                if (accountNumInput == account.AccountNb && pinInput == account.Pin)
                {
                    Bank.SearchForAccount(account.AccountNb); // Sets the correct account for to be used by the ATM after login
                    successfulLogin = true;
                    this.Hide();
                    Presentation_Layer.MainMenu mm = new Presentation_Layer.MainMenu();
                    mm.Visible = true;
                }
            }
            if (successfulLogin == false)
            {
                MessageBox.Show("Incorrect PIN!");
                txtAccountNumber.Clear();
                txtPIN.Clear();
                txtAccountNumber.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtAccountNumber.Focus(); // Sets focus to the account number input when the form loads. Can also be don in form constructor!
        }
    }
}
