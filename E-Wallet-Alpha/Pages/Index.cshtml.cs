using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace E_Wallet_Alpha.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Username { get; set; }

        [HtmlAttributeName("loggedin")]
        public bool isLoggedIn { get; set; } = false;

        public void OnGet()
        {
            string name = HttpContext.Session.GetString("user_name");

            if(name == null)
            {
                Username = "Anonymus";
            } 
            else
            {
                Username = name;
                isLoggedIn = true;
            }
        }
    }
}
