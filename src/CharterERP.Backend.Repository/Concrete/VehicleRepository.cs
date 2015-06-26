using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class VehicleRepository : RepositoryBase<EFDbContext>, IVehicleRepository
    {
        //Create and Update
        public void SaveVehicle(Vehicle vehicle)
        {
            if(vehicle.VehicleID == 0)
            {
                DataContext.Vehicles.Add(vehicle);
            }
            else
            {
                Vehicle dbEntry = DataContext.Vehicles.Find(vehicle.VehicleID);
                if(dbEntry != null)
                {
                    dbEntry.Make = vehicle.Make;
                    dbEntry.Model = vehicle.Model;
                    dbEntry.Year = vehicle.Year;
                    dbEntry.VIN = vehicle.VIN;
                    dbEntry.StockNumber = vehicle.StockNumber;
                    dbEntry.Style = vehicle.Style;
                    dbEntry.Color = vehicle.Color;
                    dbEntry.NewUsed = vehicle.NewUsed;
                    dbEntry.Mileage = vehicle.Mileage;
                    dbEntry.KBBRetail = vehicle.KBBRetail;
                    dbEntry.Cost = vehicle.Cost;
                    dbEntry.SalePrice = vehicle.SalePrice;
                    dbEntry.InternetPrice = vehicle.InternetPrice;
                    dbEntry.InventoryDate = vehicle.InventoryDate;

                    dbEntry.StoreLocation = vehicle.StoreLocation;
                    dbEntry.Dealer = vehicle.Dealer;

                }

            }

            DataContext.SaveChanges();


        }

        //Read
        public IEnumerable<Vehicle> Vehicles
        {
            get { return DataContext.Vehicles; }
        }



        //Delete
        public Vehicle DeleteVehicle (int vehicleID)
        {
            Vehicle dbEntry = DataContext.Vehicles.Find(vehicleID);

            if (dbEntry != null)
            {
                DataContext.Vehicles.Remove(dbEntry);
                DataContext.SaveChanges();
            }

            return dbEntry;
        }
    }
}
