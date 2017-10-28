using SOAPWebServices.Entities;
using SOAPWebServices.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SOAPWebServices.Core
{

    [ServiceContract(Namespace = "soap" )]
    public interface IWebService
    {

        [OperationContract(Name = "Post")]
        ServiceResponse AddPeople(People people);

        [OperationContract(Name = "Get")]
        IDictionary<string, People> GetPeople();

        [OperationContract(Name = "GetByID")]
        People GetByIDPeople(string UUID);

        [OperationContract(Name = "Put")]
        People UpdatePeople(string UUID, People people);

        [OperationContract(Name = "Delete")]
        People RemovePeople(string UUID);

    }

}
