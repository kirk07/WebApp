using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class AccountsModel : PageModel
    {
        private readonly ILogger<AccountsModel> _logger;

        public AccountsModel(ILogger<AccountsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
