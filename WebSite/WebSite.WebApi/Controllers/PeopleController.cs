using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSite.Service;
using WebSite.Service.WebService.SOAP_Firebase;

namespace WebSite.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class PeopleController : ApiController
    {
        SoapService webServicesCall;
        /// <summary>
        /// Constructor.
        /// </summary>
        public PeopleController()
        {
            webServicesCall = new SoapService();
        }

        [HttpPost, Route("people")]
        public HttpResponseMessage POST([FromBody] People people )
        {
            var response = webServicesCall.AddPeople(people); 
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpGet, Route("people"), Route("people/{key}")]
        public HttpResponseMessage GET(string key = null)
        {
            var response = (key is null) 
                ? webServicesCall.GetPeople() : webServicesCall.GetByIDPeople(key);

            return Request.CreateResponse(HttpStatusCode.OK, new { response });
        }

        [HttpPut, Route("people/{key}")]
        public HttpResponseMessage PUT(string key, [FromBody] People people)
        {
            var response = webServicesCall.UpdatePeople(key,people);
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpDelete, Route("people/{key}")]
        public HttpResponseMessage DELETE(string key)
        {
            var response = webServicesCall.RemovePeople(key);
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


    }
}
