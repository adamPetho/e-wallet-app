using E_Wallet_Alpha.DataAccessLayer.Contexts;
using E_Wallet_Alpha.Models;
using System;
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

            return _context.UserTable.Where(x => x.ID.Equals(guid)).FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return _context.UserTable.Where(x => x.Username.Equals(username)).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.UserTable.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        public void AddToHistory(Transiction payment, string id)
        {
            Guid guid = GetGUIDFromString(id);

            _context.UserTable.Where(x => x.ID.Equals(guid))
                .FirstOrDefault()
                .Transictions.Add(payment);

            _context.SaveChanges();
        }

        private Guid GetGUIDFromString(string id)
        {
            return Guid.Parse(id);
        }
    }
}
