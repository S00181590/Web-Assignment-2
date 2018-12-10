using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssForUna.Models
{
    public class Customer
    {

        [BindProperty]
        public string FirstName { get; set; }

        

        [BindProperty]
        [Required]
        public string Surname { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; } = DateTime.Now;

        [BindProperty]
        public string PPSN { get; set; }

        [BindProperty]
        public string Gender { get; set; }

        [BindProperty]
        public string height { get; set; }

        [BindProperty]
        public string phone { get; set; }

        [BindProperty]
        public string mail { get; set; }

        [BindProperty]
        public string relationship { get; set; }


     
        [BindProperty]
        public bool[] inter { get; set; } = { false, false, false, false, false, false, false, false, false, false };

      

    }
}
