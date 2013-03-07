using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_WCFService
{
    public class Customer : ICustomer
    {
        public Model.Customer Get(int customerID)
        {
            return new Model
                .AdventureWorksLT2008R2Entities()
                .Customers
                .FirstOrDefault(c => c.CustomerID == customerID);
        }

        public IEnumerable<Model.Customer> Get10()
        {
            return new Model
                .AdventureWorksLT2008R2Entities()
                .Customers
                .Take(10);
        }
    }
}
