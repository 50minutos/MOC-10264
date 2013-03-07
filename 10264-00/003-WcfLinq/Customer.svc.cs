using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _003_WcfLinq
{
    public class Customer : ICustomer
    {

        public IEnumerable<Model.Customer> Get10()
        {
            return new Model.ModelDataContext()
                .GetTable<Model.Customer>()
                .Take(10);
        }

        public Model.Customer Get(int customerID)
        {
            return new Model.ModelDataContext()
                .GetTable<Model.Customer>()
                .FirstOrDefault(c => c.CustomerID == customerID);
        }
    }
}
