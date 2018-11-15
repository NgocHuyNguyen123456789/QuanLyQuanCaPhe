using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string userName { get; set; }
        public string passWord { get; set; }

        public AccountDTO(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
    }
}
