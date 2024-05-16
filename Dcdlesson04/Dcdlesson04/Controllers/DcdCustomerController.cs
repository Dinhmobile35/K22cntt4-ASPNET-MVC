using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dcdlesson04.Models;

namespace Dcdlesson04.Controllers
{
    public class DcdCustomerController : Controller
    {
        // GET: DcdCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: DcdCustomerDetail
        public ActionResult DcdCustomerDetail()
        {
            //tạo gói đối tượng dữ liệu 
            var customer = new DcdCustomer()
            {
                CustomerId = 1,
                FirstName = "Đinh Công",
                LastName = "Định",
                Address = "k22CNTT4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        //Get: DcdListCustomer
        public ActionResult DcdListCustomer()
        {
            var list = new List<DcdCustomer>()
            {
                new DcdCustomer()
                {
                CustomerId = 1,
                FirstName = "Đinh Công",
                LastName = "Định",
                Address = "k22CNTT4",
                YearOfBirth = 2004
                },
                   new DcdCustomer()
                {
                CustomerId = 2,
                FirstName = "Đinh Công",
                LastName = "Thương 1",
                Address = "k22CNTT4",
                YearOfBirth = 2004
                },
                    new DcdCustomer()
                {
                CustomerId = 3,
                FirstName = "Đinh Công",
                LastName = "Thương 2",
                Address = "k22CNTT4",
                YearOfBirth = 2004
                },
                      new DcdCustomer()
                {
                CustomerId = 4,
                FirstName = "Đinh Công",
                LastName = "Thương 3",
                Address = "k22CNTT4",
                YearOfBirth = 2004
                },

            };
            ViewBag.list = list; //Đưa đối tượng ra view bằng đối tượng ViewBag 
            return View();
        }
    }
}