using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.DataAccessLayer
{
    public interface IDataAccess
    {
        User GetUserByEmail(string email);

        void AddUserToDB(User user);

    }
}
