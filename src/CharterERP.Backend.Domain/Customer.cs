using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }


        //Demographic Information
        public DateTime? DateofBirth { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DriversLicenseNumber { get; set; }


        //Physical Address
        public string PhysicalStreetAddress { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalState { get; set; }
        public string PhysicalPostalCode { get; set; }

        //Mailing Address
        public string MailingStreetAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }

        //Phone
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }

        //Email
        public string EmailAddress { get; set; }

        //SocialMedia?

    }
}
