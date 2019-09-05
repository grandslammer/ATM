using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business_Layer
{
    class Bank
    {
        public static List<Account> listOfAccounts = new List<Account>();
        private static Account customerAccount;
        private static bool accountFound;
        private static int accountIndexInList;

        internal static Account CustomerAccount { get => customerAccount; set => customerAccount = value; }
        public static bool AccountFound { get => accountFound; set => accountFound = value; }
        public static int AccountIndexInList { get => accountIndexInList; set => accountIndexInList = value; }

        Bank()
        {

        }

        Bank(string filePath)
        {

        }

        public static void LoadAccounts(string filePath) // Method to read from listOfAccounts
        {
            listOfAccounts = Class_FileOperation.ReadInAccounts(filePath); // Reads from txt file
        }

        public static bool SearchForAccount(string accountNb)
        {
            bool found = false;

            for (int i = 0; i < listOfAccounts.Count; i++)
            {
                if (accountNb == listOfAccounts[i].AccountNb)
                {
                    customerAccount = listOfAccounts[i];
                    accountIndexInList = i;
                    i = listOfAccounts.Count;
                    found = true;
                }
            }
            return found;
        }

        void CheckPin(string pin)
        {

        }

        public static void SaveChangesToFile(string filePath)
        {
            Class_FileOperation.WriteAccountsToFile(filePath, listOfAccounts);
        }

        public static void LoadAccountsFromDB() // Method to load accounts from database
        {
            listOfAccounts = DataAccess.DBLoadAddAccounts();
        }

        public static void SaveChangesToDB() // Method to load accounts from database
        {
            DataAccess.UpdateCustomerAccount(customerAccount);
        }
    }
}
