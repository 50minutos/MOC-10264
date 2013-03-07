using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_WCFService
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        Model.Customer Get(int customerID);

        [OperationContract]
        IEnumerable<Model.Customer> Get10();
    }
}
