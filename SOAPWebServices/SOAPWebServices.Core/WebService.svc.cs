using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using SOAPWebServices.Entities;
using SOAPWebServices.Entities.Response;

namespace SOAPWebServices.Core
{
    public class Service1 : IWebService
    {
        public async Task<ServiceResponse> AddPeople(People people)
        {
            var client = FirebaseConnection.Connection.Client();
            var response = await client.PushAsync("people", people);
            return new ServiceResponse()
            {
                FirebaseID = response.Result.name,
                Status = response.StatusCode.ToString()
            };
        }

        public async Task<ServiceResponse> GetPeople()
        {
            var client = FirebaseConnection.Connection.Client();
            var response = await client.GetAsync("people");
            return null;
        }

    }
}
