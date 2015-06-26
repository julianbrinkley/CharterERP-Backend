using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class StoreRepository : RepositoryBase<EFDbContext>, IStoreRepository
    {

        //Create and Update
        public void SaveStore(Store store)
        {
            if (store.StoreID == 0)
            {
                DataContext.Stores.Add(store);
            }
            else
            {
                Store dbEntry = DataContext.Stores.Find(store.StoreID);

                if(dbEntry != null)
                {
                    dbEntry.Name = store.Name;
                    dbEntry.StreetAddress = store.StreetAddress;
                    dbEntry.City = store.City;
                    dbEntry.State = store.State;
                    dbEntry.PostalCode = store.PostalCode;

                    dbEntry.Dealer = store.Dealer;
                    dbEntry.Vehicles = store.Vehicles;

                }


            }

            DataContext.SaveChanges();
        }



        //Read
        public IEnumerable<Store> Stores
        {
            get { return DataContext.Stores; }
        }




        //Delete
        public Store DeleteStore(int storeID)
        {

            Store dbEntry = DataContext.Stores.Find(storeID);

            if (dbEntry != null)
            {
                DataContext.Stores.Remove(dbEntry);
                DataContext.SaveChanges();

            }

            return dbEntry;

        }

    }
}
