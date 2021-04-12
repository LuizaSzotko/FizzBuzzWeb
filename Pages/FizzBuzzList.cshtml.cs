using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FizzBuzzWeb.Pages
{
    public class FizzBuzzListModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FizzBuzzContext _context;
        public IList<FizzBuzz> FizzBuzzes { get; set; }
        public FizzBuzzListModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            FizzBuzzes = _context.FizzBuzz
                .OrderByDescending(fz => fz.dt).ToList();
        }
    }
}
