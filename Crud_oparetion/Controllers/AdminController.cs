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
    public class AdminController : ApiController
    {
        [Route("api/admin/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminModel c)
        {
            var data = AdminServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
