using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business_Layer
{
    class DataAccess
    {
        static string connectionString = "Server = DESKTOP-JBAV77P;Database = ATM_DB;Trusted_Connection = true;";

        public static List<Account> DBLoadAddAccounts()
        {
            DataTable table = new DataTable();
            List<Account> ListOfAccounts = new List<Account>();

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    SqlCommand command = new SqlCommand("sp_ViewAllAccounts", dbConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    table.Load(command.ExecuteReader());
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Account tempAcc = new Account();

                    tempAcc.AccountNb = table.Rows[i]["accountNb"].ToString();
                    tempAcc.Balance = double.Parse(table.Rows[i]["balance"].ToString());
                    //tempAcc.Active = bool.Parse(table.Rows[i]["active"].ToString());
                    //tempAcc.AccountName = table.Rows[i]["accountName"].ToString();
                    tempAcc.Pin = table.Rows[i]["pin"].ToString();
                    tempAcc.PinAttempts = int.Parse(table.Rows[i]["pinAttempts"].ToString());

                    ListOfAccounts.Add(tempAcc);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return ListOfAccounts;
        }

        public static Boolean UpdateCustomerAccount(Account CustomerAccount)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored prodecure
                    SqlCommand command = new SqlCommand("sp_UpCustomerAccount", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Add parameter to command, which will be passed to the stored procedure
                    command.Parameters.Add(new SqlParameter("@accountNb", CustomerAccount.AccountNb));
                    command.Parameters.Add(new SqlParameter("@balance", CustomerAccount.Balance));
                    command.Parameters.Add(new SqlParameter("@pin", CustomerAccount.Pin));
                    command.Parameters.Add(new SqlParameter("@pinAttempts", CustomerAccount.PinAttempts));

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
