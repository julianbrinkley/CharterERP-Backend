﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Domain.Entities
{
    public enum NewUsed
    {
        New, Used
    }

    public class Vehicle
    {
      

        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public string StockNumber { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }
        public NewUsed NewUsed { get; set; }
        public int? Mileage { get; set; }
        public decimal? KBBRetail { get; set; }
        public decimal? Cost { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? InternetPrice { get; set; }
        public DateTime InventoryDate { get; set; }
        public int StoreID { get; set; }

        public virtual Store StoreLocation { get; set; }
        public virtual Dealer Dealer { get; set; }



    }
}
