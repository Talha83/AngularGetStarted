using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularGetStarted.UI.Models
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AddressL1 { get; set; }
        public string AddressL2 { get; set; }
        public string AddressL3 { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }        
    }
}