using E_Wallet_Alpha.Models;

namespace E_Wallet_Alpha.DataAccessLayer
{
    public interface IDataAccess
    {
        User GetUserByEmail(string email);

        void AddUserToDB(User user);

        User GetUserByID(string email);

        bool IsEmailExistInDB(string email);

        void UploadMoneyToUsersBalance(string id, Transaction trans);
        void PayoutFromUsersBalance(string id, Transaction newTransaction);
        void DeleteHistory(string id);
    }
}
