using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace _005_LoginAjax
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Seguranca
    {
        [OperationContract]
        public bool Logar(String nome, String senha)
        {
            var logado = nome.Equals("aaa") && senha.Equals("123");

            if(logado)
                HttpContext.Current.Session["LOGADO"] = logado;

            return logado;
        }

        [OperationContract]
        public bool Verificar()
        {
            return HttpContext.Current.Session["LOGADO"] != null;
        }
    }
}
