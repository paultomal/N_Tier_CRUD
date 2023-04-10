using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services;
using BLL.Entities;

namespace FinalApi.Controllers
{
    public class reviewController : ApiController
    {
        [Route("api/review/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ReviewServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/review/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ReviewServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/review/update")]
        [HttpPost]
        public HttpResponseMessage Update(ReviewModel c)
        {
            var data = ReviewServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/review/create")]
        [HttpPost]
        public HttpResponseMessage Create(ReviewModel c)
        {
            var data = ReviewServices.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/review/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = ReviewServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
