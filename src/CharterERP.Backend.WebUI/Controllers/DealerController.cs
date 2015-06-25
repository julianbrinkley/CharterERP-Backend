using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
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
        public ActionResult Create(Dealer dealer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DateTime current = DateTime.Now;
                    Account account = new Account { BillDate =  DateTime.Parse("2015-09-01")};
                    dealer.Account = account;

                    repository.SaveDealer(dealer);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dealer/Edit/5
        public ViewResult Edit(int id)
        {
            Dealer dealer = repository.Dealers.First(d => d.DealerID == id);

            return View(dealer);
        }

        // POST: Dealer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Dealer dealer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.SaveDealer(dealer);
                }

                return RedirectToAction("Index");
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
