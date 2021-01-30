using E_Wallet_Alpha.DataAccessLayer;
using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.Sevices
{
    public class LoginService
    {
        private readonly IDataAccess _dao;

        public LoginService(IDataAccess dao)
        {
            _dao = dao;
        }

        public User Login(string email, string password)
        {
            //Login Logic comes here

            User wannaBeLoggedIn = _dao.GetUserByEmail(email);

            if(wannaBeLoggedIn.Password.Equals(password))
            {
                return wannaBeLoggedIn;
            }

            /*if(email.Equals("admin") && password.Equals("admin"))
            {
                return new User
                {
                    Username = "HellooBelloo"
                };
            }*/


            return new User();
        }

        public void RegisterUser(string username, string email, string password)
        {
            User newOne = new User
            {
                Username = username,
                Email = email,
                Password = password,
                Balance = 0
            };

            _dao.AddUserToDB(newOne);
        }
    }
}
