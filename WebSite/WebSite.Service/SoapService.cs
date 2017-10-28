using System.Collections.Generic;
using System.Threading.Tasks;
using WebSite.Service.WebService.SOAP_Firebase;

namespace WebSite.Service
{
    public class SoapService
    {
        WebService.SOAP_Firebase.WebService webServicesCall = new WebService.SOAP_Firebase.WebService();

        public ServiceResponse AddPeople(People people) => webServicesCall.Post(people);
        
        public object GetPeople() => webServicesCall.Get();
       
        public People GetByIDPeople(string key) => webServicesCall.GetByID(key);
        
        public People UpdatePeople(string key, People people) => webServicesCall.Put(key,people);
        
        public People RemovePeople(string key) => webServicesCall.Delete(key);
        
    }
}
