using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business_Layer
{
    class Class_FileOperation
    {
        public static List<Account> ReadInAccounts(string filePath)
        {
            List<Account> listOfAccounts = new List<Account>();

            string[] allAccountData = File.ReadAllLines(filePath);

            for (int i = 0; i < allAccountData.Length; i++)
            {
                Account tempAcc = new Account(); // create object

                string[] accountParameter = allAccountData[i].Split('|'); // Splits array into different bits whenever it sees | in file

                tempAcc.AccountNb = accountParameter[0];
                tempAcc.Balance = double.Parse(accountParameter[1]);
                tempAcc.Active = bool.Parse(accountParameter[2]);
                tempAcc.AccountName = (accountParameter[3]);
                tempAcc.Pin = accountParameter[4];
                tempAcc.PinAttempts = int.Parse(accountParameter[5]);
                listOfAccounts.Add(tempAcc);
            }
            return listOfAccounts;
        }

        public static void WriteAccountsToFile(string filePath, List<Account> listOfAccounts)
        {
            try
            {
                // Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(filePath); // No need to create file C# does it for you
                string line;
                for (int i = 0; i < listOfAccounts.Count; i++)
                {
                    line = listOfAccounts[i].AccountNb.ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].Balance.ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].Active.ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].AccountName;
                    sw.Write(line + "|");

                    line = listOfAccounts[i].Pin;
                    sw.Write(line + "|");

                    line = listOfAccounts[i].PinAttempts.ToString();
                    sw.WriteLine(line + "|");
                }
                sw.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
