using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalApi.Controllers
{
    public class ManagerController : ApiController
    {
        [Route("api/manager/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ManagerServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ManagerServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/update")]
        [HttpPost]
        public HttpResponseMessage Update(ManagerModel c)
        {
            var data = ManagerServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = ManagerServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/manager/pendingtrip")]
        [HttpGet]
        public HttpResponseMessage GetPendingTrip()
        {
            var data = ManagerServices.GetPendingTrip();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/updatetrip")]
        [HttpPost]
        public HttpResponseMessage UpdateTrip(TripeModel c)
        {
            var data = ManagerServices.UpdateTrip(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/labourlist")]
        [HttpGet]
        public HttpResponseMessage Labourlist()
        {
            var data = ManagerServices.LabourList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/driverpending")]
        [HttpGet]
        public HttpResponseMessage DriverPending()
        {
            var data = ManagerServices.DriverPending();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/manager/updatedriver")]
        [HttpPost]
        public HttpResponseMessage UpdateDriver(DriverModel c)
        {
            var data = ManagerServices.UpdateDriver(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
