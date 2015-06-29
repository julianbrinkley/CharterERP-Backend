using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Models.Inventory
{
    public class InventoryCreateViewModel
    {

        [Display(Name = "Store Location")]
        [Required(ErrorMessage = "Please select the vehicle's store location")]
        public int SelectedStoreID { get; set; }

        public IEnumerable<SelectListItem> Stores { get; set; }


        [Required(ErrorMessage = "Please enter a vehicle manufacturer")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle year")]
        public int Year { get; set; }


        [Required(ErrorMessage = "Please enter a VIN")]
        public string VIN { get; set; }

        [Display(Name = "Stock Number")]
        public string StockNumber { get; set; }


        public string Style { get; set; }

        [Display(Name = "Exterior Color")]
        public string Color { get; set; }

        [Display(Name = "New or Used")]
        public string NewUsed { get; set; }

        [Display(Name = "Mileage")]
        public int? Mileage { get; set; }

        public decimal? Cost { get; set; }

        [Display(Name = "Sale Price")]
        public decimal? SalePrice { get; set; }


        //This needs to be set in the system by a service that runs in the background. 
        //..send it to a queue, service runs all this in the background and updates
        //public decimal? KBBRetail { get; set; }
        //public decimal? InternetPrice { get; set; }
    }
}