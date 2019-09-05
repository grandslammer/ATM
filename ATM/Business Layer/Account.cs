using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business_Layer
{
    class Account
    {
        private string accountNb;
        private double balance;
        private bool active;
        private string accountName;
        private string pin;
        private int pinAttempts;
        private bool blocked;
//==========================================================================
        public string AccountNb { get => accountNb; set => accountNb = value; }
        public double Balance { get => balance; set => balance = value; }
        public bool Active { get => active; set => active = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string Pin { get => pin; set => pin = value; }
        public int PinAttempts { get => pinAttempts; set => pinAttempts = value; }
        public bool Blocked { get => blocked; set => blocked = value; }
//==========================================================================
        public void MakeLodgement(double amountToLodge)
        {
            Balance = Balance + amountToLodge;
        }

       public bool MakeWithdrawal(double amountToWithdraw)
        {
            if (Balance < amountToWithdraw)
                return false;
            else
            {
                Balance = Balance - amountToWithdraw;
                return true;
            }
        }
    }
}
