using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharterERP.Backend.Domain.Entities
{
    public class Dealer
    {
        [Key]
        public int DealerID { get; set; }

        public string Name { get; set; }

        [Column("Street_Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public int AccountID { get; set; }


        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual Account Account { get; set; }

    }
}
