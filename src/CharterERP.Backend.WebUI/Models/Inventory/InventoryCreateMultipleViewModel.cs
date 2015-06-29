using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharterERP.Backend.WebUI.Models.Inventory
{
    public class InventoryCreateMultipleViewModel
    {

        [Required(ErrorMessage = "Please enter a VIN")]
        public string VIN { get; set; }
    }
}