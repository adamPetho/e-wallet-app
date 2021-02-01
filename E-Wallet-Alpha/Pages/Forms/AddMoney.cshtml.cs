using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Models;
using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages.Forms
{
    public class AddMoneyModel : PageModel
    {
        private readonly TransictionHandler _tsHandler;

        public AddMoneyModel(TransictionHandler tsHandler)
        {
            _tsHandler = tsHandler;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public string ToWho { get; set; }
        [BindProperty]
        public int Money { get; set; }
        [BindProperty]
        public bool IsChecked { get; set; }


        public IActionResult OnPost()
        {

            Transiction newOne = new Transiction
            {
                ToOrFromSomeOne = ToWho,
                AmountOfMoney = Money,
                DidIGetMoney = IsChecked
            };

            //send it to the handler

            return RedirectToPage("/Index", newOne);
        }
    }
}
