using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebSite.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class PeopleController : ApiController
    {
        [HttpGet, Route("people")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { message = "OK" });
        }
    }
}
