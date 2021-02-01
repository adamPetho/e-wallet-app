using E_Wallet_Alpha.DataAccessLayer;
using E_Wallet_Alpha.Models;
using System.Transactions;

namespace E_Wallet_Alpha.Sevices
{
    public class TransictionHandler
    {
        private readonly IDataAccess _dao;

        public TransictionHandler(IDataAccess dao)
        {
            _dao = dao;
        }

        public void AddMoneyToHistory(string id, string toOrFrom, int amount, bool didIGetMoney)
        {
            Transiction newTransiction = new Transiction
            {
                ToOrFromSomeOne = toOrFrom,
                AmountOfMoney = amount,
                DidIGetMoney = didIGetMoney
            };

            _dao.AddToHistory(newTransiction, id);
        }
    }
}
