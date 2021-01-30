using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Wallet_Alpha.Pages.Forms
{
    public class RegisterModel : PageModel
    {
        private readonly LoginService _lgService;

        public RegisterModel(LoginService lgService)
        {
            _lgService = lgService;
        }

        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(!Password.Equals(ConfirmPassword))
            {
                return Page();
            }

            _lgService.RegisterUser(Username, Email, Password);

            return RedirectToPage("/Index");
        }
    }
}
