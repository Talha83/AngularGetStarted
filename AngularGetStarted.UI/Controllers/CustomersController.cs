using AngularGetStarted.UI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularGetStarted.UI.Controllers
{
    public class CustomersController : ApiController
    {
        

        public CustomersController()
        {
            

        }

        [HttpGet]
        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            var customers = new List<CustomerViewModel>();

            for (int i = 0; i < 100; i++ )
            {
                customers.Add(new CustomerViewModel
                {
                    FirstName = "F" + i.ToString(),
                    Surname = "S" + i.ToString(),
                    Email = "a@a.com" + i.ToString(),
                    CustomerId = i,
                    AddressL1 = "L1 -" + i.ToString(),
                    AddressL2 = "L2 -" + i.ToString(),
                    AddressL3 = "L3 -" + i.ToString(),
                    PostCode = "PostCode -" + i.ToString(),
                    Phone = "0208 - " + i.ToString(),
                });
            }
            return customers;
        }

        [HttpGet]
        public CustomerViewModel GetCustomer(int id)
        {
            return new CustomerViewModel
                {
                    FirstName = "F" + id.ToString(),
                    Surname = "S" + id.ToString(),
                    Email = "a@a.com" + id.ToString(),
                    CustomerId = id,
                    AddressL1 = "L1 -" + id.ToString(),
                    AddressL2 = "L2 -" + id.ToString(),
                    AddressL3 = "L3 -" + id.ToString(),
                    PostCode = "PostCode -" + id.ToString(),
                    Phone = "0208 - " + id.ToString(),
                };
        }

        [HttpPut]
        public CustomerViewModel UpdateCustomer(CustomerViewModel customer)
        {
            var id = 1;
            return new CustomerViewModel
            {
                FirstName = "F" + id.ToString(),
                Surname = "S" + id.ToString(),
                Email = "a@a.com" + id.ToString(),
                CustomerId = id,
                AddressL1 = "L1 -" + id.ToString(),
                AddressL2 = "L2 -" + id.ToString(),
                AddressL3 = "L3 -" + id.ToString(),
                PostCode = "PostCode -" + id.ToString(),
                Phone = "0208 - " + id.ToString(),
            };
        }
    }
}