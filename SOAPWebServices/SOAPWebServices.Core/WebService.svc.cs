using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using Newtonsoft.Json;
using SOAPWebServices.Entities;
using SOAPWebServices.Entities.Response;
using FireSharp.Interfaces;

namespace SOAPWebServices.Core
{
    public class Service1 : IWebService
    {
        IFirebaseClient client = FirebaseConnection.Connection.Client();
        public async Task<ServiceResponse> AddPeople(People people)
        {           
            var response = await client.PushAsync("people", people);
            return new ServiceResponse()
            {
                FirebaseID = response.Result.name,
                Status = response.StatusCode.ToString()
            };
        }

        public async Task<IDictionary<string, People>> GetPeople()
        {                    
            var response = await client.GetAsync("people");
            var data = response?.ResultAs<IDictionary<string, People>>();            
            return data;
        }

        public async Task<People> GetByIDPeople(string key)
        {
            var response = await client.GetAsync($"people/{key}");
            var data = response?.ResultAs<People>();

            return data;
        }

    }
}
