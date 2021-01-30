using E_Wallet_Alpha.DataAccessLayer;
using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.ViewModels
{
    public class ViewModel
    {
        private static ViewModel instance;
        private readonly DaoTest _dao;
        public User LoggedInUser;

        public ViewModel(DaoTest daoTest)
        {
            _dao = daoTest;
        }

        public User GetTestUser()
        {
            return _dao.GetDummyUser();
        }

       public bool Login(string username, string password)
        {
            bool isSuccessful = false;

            //Login Logic comes here

            if(username.Equals("test") && password.Equals("test"))
            {
                isSuccessful = true;
                LoggedInUser = _dao.GetLoggedInDummyUser();
            }


            return isSuccessful;
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
        }


        public static ViewModel GetInstance()
        {
            if(instance == null)
            {
                instance = new ViewModel(new DaoTest());
            }

            return instance;
        }
    }
}
