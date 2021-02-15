using E_Wallet_Alpha.DataAccessLayer.Contexts;
using E_Wallet_Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Wallet_Alpha.DataAccessLayer
{
    public class DataAccessClass : IDataAccess
    {
        private readonly UserContext _context;

        public DataAccessClass(UserContext context)
        {
            _context = context;
        }

        public void AddUserToDB(User newUser)
        {
            _context.UserTable.Add(newUser);

            _context.SaveChanges();
        }

        public bool IsEmailExistInDB(string email)
        {
            return _context.UserTable.Any(x => x.Email.Equals(email));
        }

        public User GetUserByID(string id)
        {
            Guid guid = GetGUIDFromString(id);

            User user = _context.UserTable.Where(x => x.ID.Equals(guid)).FirstOrDefault();

            user.Transictions = GetLastFiveHistoryOrderDESC(guid);

            return user;
        }

        public User GetUserByUsername(string username)
        {
            return _context.UserTable.Where(x => x.Username.Equals(username)).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.UserTable.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        public void UploadMoneyToUsersBalance(string id, Transaction payment)
        {
            Guid guid = GetGUIDFromString(id);

            User user = _context.UserTable.Where(x => x.ID.Equals(guid))
                .FirstOrDefault();

            payment.UserID = guid;

            user.Transictions.Add(payment);

            user.Balance += payment.AmountOfMoney;

            _context.SaveChanges();
        }

        public void PayoutFromUsersBalance(string id, Transaction payment)
        {
            Guid guid = GetGUIDFromString(id);

            User user = _context.UserTable.Where(x => x.ID.Equals(guid))
                .FirstOrDefault();

            payment.UserID = guid;

            user.Transictions.Add(payment);

            user.Balance -= payment.AmountOfMoney;

            _context.SaveChanges();
        }

        public void DeleteHistory(string id)
        {
            Guid guid = GetGUIDFromString(id);

            foreach(var transactionToDelete in _context.TransictionTable.Where(x=> x.UserID == guid))
            {
                _context.TransictionTable.Remove(transactionToDelete);
            }

            _context.SaveChanges();
        }

        private List<Transaction> GetHistoryOfUserOrderDESC(Guid id)
        {
            return _context.TransictionTable.Where(x => x.UserID == id).OrderBy(x => x.Date).Reverse().ToList();
        }

        private List<Transaction> GetLastFiveHistoryOrderDESC(Guid id)
        {
            return _context.TransictionTable.Where(x => x.UserID == id).OrderBy(x => x.Date).Take(5).ToList();
        }


        private Guid GetGUIDFromString(string id)
        {
            return Guid.Parse(id);
        }
    }
}
