using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FZ { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            FZ.Result = FizzBuzzFunction(FZ);
            FZ.dt = DateTime.UtcNow.ToLocalTime();
            FZ.dt.ToString("dd-MM-yyyy hh:mm:ss");
            HttpContext.Session.SetString("SessionFizzBuzz", JsonConvert.SerializeObject(FZ));
            return RedirectToPage("./FizzBuzzSession");
        }

        static string FizzBuzzFunction(FizzBuzz FZ)
        {
            string result = "";
            int number = FZ.Number;
            if (number % 3 == 0) result += "fizz";
            if (number % 5 == 0) result += "buzz";
            if (result == "") result = number.ToString();
            return result;
        }
    }
}
