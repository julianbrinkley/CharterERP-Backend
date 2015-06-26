using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharterERP.Backend.WebUI.Models.Dealer
{
    public class DealerEditViewModel
    {
        [Required(ErrorMessage = "Please enter a dealership name")]
        public string Name { get; set; }

        public int DealerID { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Please enter a street address")]
        public string StreetAddress { get; set; }


        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please enter a postal code")]
        public string PostalCode { get; set; }

    }
}