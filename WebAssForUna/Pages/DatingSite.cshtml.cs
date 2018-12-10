using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAssForUna.Models;

namespace WebAssForUna.Pages
{
    public class sampleModel : PageModel
    {

        public Customer Customer { get; set; }


        public string Namedisp { get; set; } = "";

        public string ppsndisp { get; set; } = "";

        public string datedisp { get; set; } = "";

        public string genddisp { get; set; } = "";

        public string heightdisp { get; set; } = "";

        public string numdisp { get; set; } = "";

        public string maildisp { get; set; } = "";

        public string reldisp { get; set; } = "";

        public string intdisp { get; set; } = "";

       
       
        public string[] interests = { "Outdoor Sports", "Food", "Pubs", "Cinema", "Theatre", "Music", "Reading", "Gaming", "Watching Sports", "Board Games" };

        public string[] message = { "", "", "", "", "", "", "", "", "", "" };


      

        public string mess { get; set; } = " ";

        public void OnPost()
        {

            if (ModelState.IsValid)
            {
                // go to the next page
            }

        }

        //    Namedisp = "Name: " + FirstName + " " + Surname;

        //    ppsndisp = "PPSN: " + PPSN;

        //    datedisp = "Date of Birth: " + DOB.ToShortDateString();

        //    genddisp = "Gender: " + Gender;

        //    heightdisp = "Height: " + height;

        //    numdisp = "Phone Number: " + phone;

        //    maildisp = "E-mail Address: " + mail;

        //    reldisp = "Relationship Status: " + mail;

        //    //for (int i = 0; i <= inter.Length-1; i++)
        //    //{
               

        //    //}

        //    //mess = " " + message[0] + " " + message[0] + " " + message[1] + " " + message[2] + " " + message[3] + " " + message[4] + " " + message[5] + " " + message[6] + " " + message[7] + " " + message[8] + " " + message[9];

        //}

    }
}