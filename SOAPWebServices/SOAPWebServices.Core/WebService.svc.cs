using System.Collections.Generic;
using System.Threading.Tasks;
using SOAPWebServices.Entities;
using SOAPWebServices.Entities.Response;
using FireSharp.Interfaces;

namespace SOAPWebServices.Core
{
    public class WebService : IWebService
    {

        IFirebaseClient client = FirebaseConnection.Connection.Client();

        #region AddPeople 
        public ServiceResponse AddPeople(People people)
        {           
            var response = client.Push("people", people);
            return new ServiceResponse()
            {
                FirebaseID = response.Result.name,
                Status = response.StatusCode.ToString()
            };
        }
        #endregion

        #region GetPeople 
        public IDictionary<string, People> GetPeople()
        {                    
            var response = client.Get("people");
            return response?.ResultAs<IDictionary<string, People>>();            
        }
        #endregion

        #region GetByIDPeople 
        public People GetByIDPeople(string key)
        {
            var response = client.Get($"people/{key}");
            return response?.ResultAs<People>();
        }
        #endregion

        #region UpdatePeople 
        public People UpdatePeople(string key, People people)
        {
            People data = null;
            if (GetByIDPeople(key) != null)
            {
                var response = client.Update($"people/{key}", people);
                data = new People();
                data = response?.ResultAs<People>();
            }

            return data;
        }
        #endregion

        #region RemovePeople
        public People RemovePeople(string key)
        {
            People data = null;
            if (GetByIDPeople(key) != null)
            {
                var response = client.Delete($"people/{key}");
                data = new People();
                data = response?.ResultAs<People>();             
            }
            return data;
        }
        #endregion

    }
}
