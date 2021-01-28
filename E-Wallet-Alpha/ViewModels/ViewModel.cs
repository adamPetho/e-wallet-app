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
