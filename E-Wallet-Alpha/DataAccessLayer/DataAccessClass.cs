using E_Wallet_Alpha.DataAccessLayer.Contexts;
using E_Wallet_Alpha.Models;
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
            /*_context.UserTable.Add(newUser);

            _context.SaveChanges();*/
        }

        public User GetUserByEmail(string email)
        {
            return _context.UserTable.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        public void AddToHistore(Transiction payment, string email)
        {
            _context.UserTable.Where(x => x.Email.Equals(email))
                .FirstOrDefault()
                .Transictions.Add(payment);

            _context.SaveChanges();
        }
    }
}
