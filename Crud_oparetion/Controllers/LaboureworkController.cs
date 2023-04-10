using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace FinalApi.Controllers
{
    public class LaboureworkController : ApiController
    {
        [Route("api/lwork/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = l_workScheduleServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/lwork/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = l_workScheduleServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/lwork/update")]
        [HttpPost]
        public HttpResponseMessage Update(l_workScheduleModel c)
        {
            var data = l_workScheduleServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/lwork/create")]
        [HttpPost]
        public HttpResponseMessage Create(l_workScheduleModel c)
        {
            var data = l_workScheduleServices.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/lwork/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = l_workScheduleServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
