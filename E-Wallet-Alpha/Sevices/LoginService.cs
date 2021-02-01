using E_Wallet_Alpha.DataAccessLayer;
using E_Wallet_Alpha.Models;
using System;

namespace E_Wallet_Alpha.Sevices
{
    public class LoginService
    {
        private readonly IDataAccess _dao;
        private readonly PasswordHasher _pwHasher;

        public LoginService(IDataAccess dao, PasswordHasher pwHasher)
        {
            _dao = dao;
            _pwHasher = pwHasher;
        }

        public User Login(string email, string password)
        {
            //Login Logic comes here

            User wannaBeLoggedIn = _dao.GetUserByEmail(email);

            try
            {
                if(_pwHasher.VerifyPasswords(password,wannaBeLoggedIn.Password))
                {
                    return wannaBeLoggedIn;
                }
            } 
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            return new User();
        }

        public void RegisterUser(string username, string email, string password)
        {
            User newOne = new User
            {
                Username = username,
                Email = email,
                Password = _pwHasher.CreateHashedPassword(password),
                Balance = 0
            };

            if(_dao.IsEmailExistInDB(email))
            {
                throw new Exception("Email already exist in Database");
            }

            _dao.AddUserToDB(newOne);
        }

        public User GetUserByID(string id)
        {
            return _dao.GetUserByID(id);
        }
    }
}
