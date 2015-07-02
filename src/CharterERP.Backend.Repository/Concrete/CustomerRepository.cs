using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class CustomerRepository : RepositoryBase<EFDbContext>, ICustomerRepository
    {
        public IEnumerable<Customer> Customers
        {
            get { return DataContext.Customers; }
        }



        public void SaveCustomer(Customer customer)
        {

            if(customer.CustomerID == 0)
            {
                DataContext.Customers.Add(customer);

            }
            else
            {
                Customer dbEntry = DataContext.Customers.Find(customer.CustomerID);

                if(dbEntry != null)
                {
                    dbEntry.DateofBirth = customer.DateofBirth;
                    dbEntry.DriversLicenseNumber = customer.DriversLicenseNumber;
                    dbEntry.EmailAddress = customer.EmailAddress;
                    dbEntry.FirstName = customer.FirstName;
                    dbEntry.HomePhoneNumber = customer.HomePhoneNumber;
                    dbEntry.LastName = customer.LastName;
                    dbEntry.MailingCity = customer.MailingCity;
                    dbEntry.MailingPostalCode = customer.MailingPostalCode;
                    dbEntry.MailingState = customer.MailingState;
                    dbEntry.MailingStreetAddress = customer.MailingStreetAddress;
                    dbEntry.MiddleName = customer.MiddleName;
                    dbEntry.MobilePhoneNumber = customer.MobilePhoneNumber;
                    dbEntry.PhysicalCity = customer.PhysicalCity;
                    dbEntry.PhysicalPostalCode = customer.PhysicalPostalCode;
                    dbEntry.PhysicalState = customer.PhysicalState;
                    dbEntry.PhysicalStreetAddress = customer.PhysicalStreetAddress;
                    dbEntry.SocialSecurityNumber = customer.SocialSecurityNumber;
                    dbEntry.WorkPhoneNumber = customer.WorkPhoneNumber;
                }

            }

            DataContext.SaveChanges();

        }


        //Delete
        public Customer DeleteCustomer(int customerID)
        {
            Customer dbEntry = DataContext.Customers.Find(customerID);

            if(dbEntry != null)
            {
                DataContext.Customers.Remove(dbEntry);
                DataContext.SaveChanges();
            }

            return dbEntry;


        }

    }
}
