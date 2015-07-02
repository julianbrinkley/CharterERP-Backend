using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using CharterERP.Backend.WebUI.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharterERP.Backend.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

        }

        // GET: Customer
        public ActionResult Index()
        {

            return View(customerRepository.Customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = customerRepository.Customers.First(c => c.CustomerID == id);

            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateViewModel data)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    Customer customer = new Customer
                    {

                        //DateofBirth = data.DateofBirth,
                        DriversLicenseNumber = data.DriversLicenseNumber,
                        EmailAddress = data.EmailAddress,
                        FirstName = data.FirstName,
                        HomePhoneNumber = data.HomePhoneNumber,
                        LastName = data.LastName,
                        MailingCity = data.MailingCity,
                        MailingPostalCode = data.MailingPostalCode,
                        MailingState = data.MailingState,
                        MailingStreetAddress = data.MailingStreetAddress,
                        MiddleName = data.MiddleName,
                        MobilePhoneNumber = data.MobilePhoneNumber,
                        PhysicalCity = data.PhysicalCity,
                        PhysicalPostalCode = data.PhysicalPostalCode,
                        PhysicalState = data.PhysicalState,
                        PhysicalStreetAddress = data.PhysicalStreetAddress,
                        SocialSecurityNumber = data.SocialSecurityNumber,
                        WorkPhoneNumber = data.WorkPhoneNumber

                    };

                    customerRepository.SaveCustomer(customer);

                    return RedirectToAction("Index");

                }

                return View(data);

            }
            catch
            {
                return View(data);
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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
