﻿using System;
using System.Collections.Generic;

namespace Northwind.DAL.Models
{
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            CustomerCustomerDemo = new HashSet<CustomerCustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
