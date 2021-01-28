using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Wallet_Alpha.Models;
using E_Wallet_Alpha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace E_Wallet_Alpha.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ViewModel _vm;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _vm = ViewModel.GetInstance();
        }

        public User UserToShow { get; set; }

        public void OnGet()
        {
            if(_vm.LoggedInUser == null)
            {
                _vm.LoggedInUser = _vm.GetDummyUser();
            }
            UserToShow = _vm.LoggedInUser;
        }
    }
}
