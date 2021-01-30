using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages.Forms
{
    public class LoginModel : PageModel
    {
        private readonly ViewModel _vm;
        public LoginModel()
        {
            _vm = ViewModel.GetInstance();
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(!_vm.Login(Username, Password))
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}
