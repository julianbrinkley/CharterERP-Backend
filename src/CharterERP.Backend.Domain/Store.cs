using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Domain.Entities
{
   public class Store
    {
        [Key]
        public int StoreID { get; set; }
        public string Name { get; set; }
        [Column("Street_Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int AccountId { get; set; }
    }
}
