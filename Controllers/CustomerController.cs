using CrudR.Data_Access;
using CrudR.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudR.Controllers
{
    public class CustomerController : Controller
    {
        public DatabaseConn _DBCONN { get; }
        public CustomerController(DatabaseConn DBCONN)
        {
            this._DBCONN = DBCONN;
        }

        public IActionResult Index()
        {
            //List<Customer> data = _DBCONN.Customers.ToList();
            var data = _DBCONN.Customers.ToList();
            return View(data);
        }
        public IActionResult Create()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customers)
        {
            _DBCONN.Customers.Add(customers);
            _DBCONN.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
