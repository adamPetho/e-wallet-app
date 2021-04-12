using E_Wallet_Alpha.DataAccessLayer;
using E_Wallet_Alpha.Models;
using System.Transactions;

namespace E_Wallet_Alpha.Sevices
{
    public class TransactionHandler
    {
        private readonly IDataAccess _dao;

        public TransactionHandler(IDataAccess dao)
        {
            _dao = dao;
        }

        public void AddMoneyToHistory(string id, Models.Transaction newTransaction)
        {

            _dao.UploadMoneyToUsersBalance(id, newTransaction);
        }

        public void AddPayoutToHistory(string id, Models.Transaction newTransaction)
        {
            _dao.PayoutFromUsersBalance(id, newTransaction);
        }

        public void ClearHistory(string id)
        {
            _dao.DeleteHistory(id);
        }
    }
}
