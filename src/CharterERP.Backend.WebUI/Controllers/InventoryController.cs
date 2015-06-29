using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using CharterERP.Backend.WebUI.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Controllers
{
    public class InventoryController : Controller
    {

        private IVehicleRepository repository;
        private IStoreRepository storeRepository;

        public InventoryController(IVehicleRepository vehicleRepository, IStoreRepository storeRepository)
        {
            this.repository = vehicleRepository;
            this.storeRepository = storeRepository;

        }


        //Method to create a Select List of All Stores in the system
        private IEnumerable<SelectListItem> GetStores()
        {
            var stores = storeRepository.Stores.Select( s =>
                new SelectListItem
                {
                    Value = Convert.ToString(s.StoreID),
                    Text = s.Name
                });

            return new SelectList(stores, "Value", "Text");
        }


        // GET: Inventory
        public ActionResult Index()
        {
            return View(repository.Vehicles);
        }


        // GET: Inventory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventory/CreateMultiple
        public ActionResult CreateMultiple()
        {

            return View();
        }

        // POST: Inventory/CreateMultiple
        [HttpPost]
        public ActionResult CreateMultiple(FormCollection data)
        {

            return View();
        }


        // GET: Inventory/Create
        public ActionResult Create()
        {
            var model = new InventoryCreateViewModel { Stores = GetStores() };

            return View(model);
        }

        // POST: Inventory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InventoryCreateViewModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    //Vehicle vehicle = new Vehicle
                    //{
                    //      Color = data.Color,
                    //      Cost = data.Cost,
                    //      Dealer = , //set the dealer in a global variable?
                    //      InternetPrice = 0.00m,
                    //      InventoryDate = DateTime.Now,
                    //      KBBRetail = 0.00m,
                    //      Mileage = data.Mileage,
                    //      NewUsed = Domain.Entities.NewUsed.Used, //change this to have a new used drop down
                    //      SalePrice = data.SalePrice,
                    //      StockNumber = data.StockNumber,
                    //      StoreLocation = , //need a drop down with the stores
                    //      Style = data.Style,
                    //      VIN = data.VIN,
                    //      Year = data.Year,
                    //      Make = data.Make,
                    //      Model = data.Model
                           
                        
                    //};

                    //repository.SaveVehicle(vehicle);

                    return RedirectToAction("Index");
                }

                return View(data);

            }
            catch
            {
                return View(data);
            }
        }

        // GET: Inventory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inventory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
