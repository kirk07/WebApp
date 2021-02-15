using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class ForumModel : PageModel
    {
        private readonly ILogger<ForumModel> _logger;

        public ForumModel(ILogger<ForumModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
