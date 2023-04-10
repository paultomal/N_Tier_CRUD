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
    [EnableCors("*", "*", "*")]
    public class ActivityLogController : ApiController
    {
        [Route("api/activitylog/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {

            var data = ActivityLogServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/activitylog/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ActivityLogServices.Getbyuser(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/activitylog/update")]
        [HttpPost]
        public HttpResponseMessage Update(ActivityLogModel a)
        {
            var data = ActivityLogServices.Update(a);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/activitylog/create")]
        [HttpPost]
        public HttpResponseMessage Create(ActivityLogModel a)
        {
            var data = ActivityLogServices.Create(a);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/activitylog/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = ActivityLogServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}