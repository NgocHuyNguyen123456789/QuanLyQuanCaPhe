using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO : DataProvider
    {
        public bool Login(AccountDTO acc)
        {
            string sql = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + acc.userName + "' AND Password = '" + acc.passWord + "'";            
            int number;
            try
            {
                number = myExecuteScalar(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (number > 0)
                return true;
            else
                return false;
        }
    }
}
