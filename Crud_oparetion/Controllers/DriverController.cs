using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FinalApi.Controllers
{
 
    public class DriverController : ApiController
    {
        [Route("api/driver/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {

            var data = DriverServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/driver/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = DriverServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/driver/update")]
        [HttpPost]
        public HttpResponseMessage Update(DriverModel d)
        {
            var data = DriverServices.Update(d);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/driver/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel d)
        {
            var data = DriverServices.Create(d);
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
        [Route("api/driver/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = DriverServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/driver/mytrips/{id}")]
        [HttpGet]
        public HttpResponseMessage GetMyTrips(int id)
        {
            var data = DriverServices.GetMyTrips(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/driver/availabletrips")]
        [HttpGet]
        public HttpResponseMessage getalltrip()
        {
            var data = DriverServices.getalltrip();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/driver/getatrip/{id}")]
        [HttpGet]
        public HttpResponseMessage GetATrip(int id)
        {
            var data = DriverServices.GetATrip(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/driver/confirmation")]
        [HttpPost]
        public HttpResponseMessage ConfirmationTrip(TripeModel d)
        {
            var data = DriverServices.ConfirmationTrip(d);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}