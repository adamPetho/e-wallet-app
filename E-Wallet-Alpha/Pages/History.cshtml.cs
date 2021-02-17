using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Models;
using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly LoginService _lgService;

        public HistoryModel(LoginService lg)
        {
            _lgService = lg;
        }

        public User LoggedInUser { get; set; }

        public void OnGet()
        {
            string guidInString = HttpContext.Session.GetString("user_id");


            if (HttpContext.Session.GetString("user_id") == null)
            {
                throw new Exception("You should be logged in");
            }
            else
            {
                //data holder
                LoggedInUser = _lgService.GetUserByID(guidInString);
            }
        }
    }
}
