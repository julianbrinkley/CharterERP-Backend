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

        [Required(ErrorMessage = "Please enter a dealership name")]
        public string Name { get; set; }

        [Display(Name="Street Address")]
        [Required(ErrorMessage= "Please enter a street address")]
        [Column("Street_Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please enter a postal code")]
        public string PostalCode { get; set; }

        public int AccountID { get; set; }


        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual Account Account { get; set; }

    }
}
