using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        public bool Login(AccountDTO acc)
        {
            try
            {
                return new AccountDAO().Login(acc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
