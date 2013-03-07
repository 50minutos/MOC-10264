using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _003_WcfLinq
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        IEnumerable<Model.Customer> Get10();

        [OperationContract]
        Model.Customer Get(int customerID);
    }
}
