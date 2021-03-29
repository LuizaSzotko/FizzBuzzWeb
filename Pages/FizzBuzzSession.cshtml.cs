using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Pages
{
    public class FizzBuzzSessionModel : PageModel
    {
        public FizzBuzz FZ { get; set; }
        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionFizzBuzz != null)
                FZ = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);
        }
    }
}
