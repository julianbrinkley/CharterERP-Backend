using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using CharterERP.Backend.WebUI.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Controllers
{
    public class StoreController : Controller
    {
        private IStoreRepository repository;
        private IDealerRepository dealerRepository;

        public StoreController(IStoreRepository storeRepository, IDealerRepository dealerRepository)
        {
            this.repository = storeRepository;
            this.dealerRepository = dealerRepository;

        }

        //Method to create a Select List of All Dealers in the system
        private IEnumerable<SelectListItem> GetDealers()
        {
            var dealers = dealerRepository.Dealers.Select(d =>
                new SelectListItem
                {
                    Value = Convert.ToString(d.DealerID),
                    Text = d.Name

                });


            return new SelectList(dealers, "Value", "Text");
        }


        // GET: Store
        public ActionResult Index()
        {

            return View(repository.Stores);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            Store store = repository.Stores.First(s => s.StoreID == id);

            return View(store);
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            var model = new StoreCreateViewModel { Dealers = GetDealers() };

            return View(model);
        }

        // POST: Store/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StoreCreateViewModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    Store store = new Store
                    {

                        Name = data.Name,
                        StreetAddress = data.StreetAddress,
                        City = data.City,
                        State = data.State,
                        PostalCode = data.PostalCode,
                        DealerID = dealerRepository.Dealers.First(d => d.DealerID == data.SelectedDealerID).DealerID
                    };


                    repository.SaveStore(store);

                    return RedirectToAction("Index");
                }

                return View(data);

            }
            catch
            {
                return View(data);
            }
        }

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            Store store = repository.Stores.First(s => s.StoreID == id);

            var model = new StoreEditViewModel
            {
                Name = store.Name,
                StreetAddress = store.StreetAddress,
                City = store.City,
                State = store.State,
                PostalCode = store.PostalCode


            };


            return View(model);
        }

        // POST: Store/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StoreEditViewModel data)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    Store store = new Store
                    {
                        StoreID = data.StoreID,
                        Name = data.Name,
                        StreetAddress = data.StreetAddress,
                        City = data.City,
                        State = data.State,
                        PostalCode = data.PostalCode

                    };

                    repository.SaveStore(store);
                    return RedirectToAction("Index");
                }

                return View(data);


            }
            catch
            {
                return View(data);
            }
        }

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            Store store = repository.Stores.FirstOrDefault(s => s.StoreID == id);

            return View(store);
        }

        // POST: Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.DeleteStore(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
