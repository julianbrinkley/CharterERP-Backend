using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class DealerRepository : RepositoryBase<EFDbContext>, IDealerRepository
    {

        //Create and Update
        public void SaveDealer(Dealer dealer)
        {
            if (dealer.DealerID == 0)
            {
                DataContext.Dealers.Add(dealer);
            }
            else
            {
                Dealer dbEntry = DataContext.Dealers.Find(dealer.DealerID);
                if (dbEntry != null)
                {
                    dbEntry.Name = dealer.Name;
                    dbEntry.StreetAddress = dealer.StreetAddress;
                    dbEntry.City = dealer.City;
                    dbEntry.State = dealer.State;
                    dbEntry.PostalCode = dealer.PostalCode;
                    dbEntry.AccountID = dealer.AccountID;

                    dbEntry.Stores = dealer.Stores;
                    dbEntry.Employees = dealer.Employees;
                    dbEntry.Vehicles = dealer.Vehicles;

                    dbEntry.Account = dealer.Account;

                }
            }

            DataContext.SaveChanges();
        }



        //Read
        public IEnumerable<Dealer> Dealers
        {
            get { return DataContext.Dealers; }
        }


        //Delete
        public Dealer DeleteDealer(int dealerID)
        {
            Dealer dbEntry = DataContext.Dealers.Find(dealerID);

            if (dbEntry != null)
            {
                DataContext.Dealers.Remove(dbEntry);
                DataContext.SaveChanges();
            }

            return dbEntry;
        }



    }
}
