using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using CharterERP.Backend.WebUI.Models.Dealer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Controllers
{
    public class DealerController : Controller
    {
        private IDealerRepository repository;

        public DealerController(IDealerRepository dealerRepository)
        {
            this.repository = dealerRepository;

        }

        // GET: Dealer
        public ViewResult Index()
        {
            return View(repository.Dealers);
        }

        // GET: Dealer/Details/5
        public ActionResult Details(int id)
        {
            Dealer dealer = repository.Dealers.First(d => d.DealerID == id);

            return View(dealer);
        }

        // GET: Dealer/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Dealer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DealerCreateViewModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                
                    Dealer dealer = new Dealer
                    {
                        Name = data.Name,
                        StreetAddress = data.StreetAddress,
                        City = data.City,
                        State = data.State,
                        PostalCode = data.PostalCode,
                        Account = new Account { BillDate =  DateTime.Parse("2015-09-01")}
                    };

                    repository.SaveDealer(dealer);                
                    
                    return RedirectToAction("Index");
                }

                return View(data);

            }
            catch
            {
                return View(data);
            }
        }

        // GET: Dealer/Edit/5
        public ActionResult Edit(int id)
        {
            Dealer dealer = repository.Dealers.First(d => d.DealerID == id);

            var model = new DealerEditViewModel 
            {
                Name = dealer.Name,
                StreetAddress =dealer.StreetAddress,
                City = dealer.City,
                State = dealer.State,
                PostalCode = dealer.PostalCode,
                DealerID = dealer.DealerID 
            };

            return View(model);
        }

        // POST: Dealer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DealerEditViewModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Dealer dealer = new Dealer
                    {
                        DealerID = data.DealerID,
                        Name = data.Name,
                        StreetAddress = data.StreetAddress,
                        City = data.City,
                        State = data.State,
                        PostalCode = data.PostalCode,
                    };

                    repository.SaveDealer(dealer);                
                    return RedirectToAction("Index");
                }

                return View(data);


            }
            catch
            {
                return View();
            }
        }

        // GET: Dealer/Delete/5
        public ActionResult Delete(int id)
        {
            Dealer dealer = repository.Dealers.FirstOrDefault(d => d.DealerID == id);

            return View(dealer);
        }

        // POST: Dealer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.DeleteDealer(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
