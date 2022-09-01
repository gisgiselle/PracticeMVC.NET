using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Amamama"},
                new Customer {Id = 2, Name = "JAJAJA"}
            };
        }

    }
}