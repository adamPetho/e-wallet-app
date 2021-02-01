using E_Wallet_Alpha.Models;
using E_Wallet_Alpha.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace E_Wallet_Alpha.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LoginService _lgService;

        public IndexModel(ILogger<IndexModel> logger, LoginService lg)
        {
            _logger = logger;
            _lgService = lg;
        }

        public User LoggedInUser { get; set; }

        [HtmlAttributeName("loggedin")]
        public bool isLoggedIn { get; set; } = true;

        public void OnGet()
        {
            string guidInString = HttpContext.Session.GetString("user_id");


            if(HttpContext.Session.GetString("user_id") == null)
            {
                isLoggedIn = false;
            } 
            else
            {
                //data holder
                LoggedInUser = _lgService.GetUserByID(guidInString); 
                
                //Can view it
                isLoggedIn = true;
            }
        }
    }
}
