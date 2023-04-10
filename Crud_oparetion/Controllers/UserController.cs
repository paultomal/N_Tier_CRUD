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
    public class UserController : ApiController
    {
        [Route("api/user/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(UserModel c)
        {
            var data = UserServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
