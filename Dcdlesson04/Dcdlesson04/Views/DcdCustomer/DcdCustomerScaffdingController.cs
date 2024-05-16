using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dcdlesson04.Controllers;
using Dcdlesson04.Models;

namespace Dcdlesson04.Views.DcdCustomer
{
    public class DcdCustomerScaffdingController : Controller
    {
        //mockdata
        private List<DcdCustomer> listCustomer = new List<DcdCustomer>()
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
    // GET: DcdCustomerScaffding
    public ActionResult Index()
        {
            return View();
        }
    }
}