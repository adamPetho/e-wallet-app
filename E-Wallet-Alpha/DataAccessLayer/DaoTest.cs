using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.DataAccessLayer
{
    public class DaoTest
    {

        public User GetDummyUser()
        {
            return new User
            {
                Username = "Anonymus",
                Balance = 0
            };
        }

        public User GetLoggedInDummyUser()
        {
            return new User
            {
                Username = "LoggedIn",
                Balance = 350
            };
        }
    }
}
