using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Models.Store
{
    public class StoreCreateViewModel
    {
        [Display(Name = "Dealer Name")]
        [Required(ErrorMessage = "Please select a dealer")]
        public int SelectedDealerID { get; set; }

        public IEnumerable <SelectListItem> Dealers  { get; set; }

        [Display(Name = "Store Name")]
        [Required(ErrorMessage = "Please enter a store name")]
        public string Name { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Please enter a street address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Please enter a zip/postal code")]
        public string PostalCode { get; set; }

    }
}