using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.DataAccessLayer
{
    public class DaoTest
    {

        private string GetName()
        {
            return "Adam";
        }

        private int GetBalance()
        {
            return 350;
        }

        public User GetDummyUser()
        {
            return new User
            {
                ID = 1,
                Username = GetName(),
                Balance = GetBalance()
            };
        }
    }
}
