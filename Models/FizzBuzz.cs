using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Liczba")]
        [Range(1, 1000, ErrorMessage = "Wartość musi być z przedziału 1 - 1000"), Required(ErrorMessage = "Pole jest obowiązkowe!")]
        public int Number { get; set; }
        [Display(Name = "Wynik")]
        public string Result { get; set; }
        [Display(Name = "Data")]
        public DateTime dt { get; set; } 

    }
}
