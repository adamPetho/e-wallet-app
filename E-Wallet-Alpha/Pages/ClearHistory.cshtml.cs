using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages
{
    public class ClearHistoryModel : PageModel
    {
        private readonly TransactionHandler _tsHandler;

        public ClearHistoryModel(TransactionHandler tsHandler)
        {
            _tsHandler = tsHandler;
        }
        public IActionResult OnGet()
        {
            string id = HttpContext.Session.GetString("user_id");

            if(id == null)
            {
                return RedirectToPage("/Forms/Login");
            }

            _tsHandler.ClearHistory(id);

            return RedirectToPage("/Index");
        }
    }
}
