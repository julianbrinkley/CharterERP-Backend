using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharterERP.Backend.WebUI.Models.Dealer
{
    public class CreateViewModel
    {

        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}