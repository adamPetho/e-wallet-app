using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Models;
using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages.Forms
{
    public class PayoutModel : PageModel
    {
        private readonly TransactionHandler _tsHandler;

        public PayoutModel(TransactionHandler tsHandler)
        {
            _tsHandler = tsHandler;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public int Money { get; set; }
        [BindProperty]
        public string Target { get; set; }


        public IActionResult OnPost()
        {
            if (Money == 0)
            {
                return Page();
            }
            try
            {
                Transaction newTransaction = new Transaction
                {
                    Receiver = Target,
                    AmountOfMoney = Money,
                    DidIGetMoney = false,
                    Date = DateTime.Now
                };

                string id = HttpContext.Session.GetString("user_id");

                _tsHandler.AddPayoutToHistory(id, newTransaction);

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToPage("/Index");
        }
    }
}
