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
    public class LoginModel : PageModel
    {
        private readonly LoginService _loginService;

        public LoginModel(LoginService loginService)
        {
            _loginService = loginService;
        }

        [BindProperty]
        public string Email { get; set; }

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

            User loggedin = _loginService.Login(Email, Password);

            if(loggedin.Username == null)
            {
                return Page();
            }

            HttpContext.Session.SetString("user_id", loggedin.ID.ToString());

            return RedirectToPage("/Index");
        }
    }
}
