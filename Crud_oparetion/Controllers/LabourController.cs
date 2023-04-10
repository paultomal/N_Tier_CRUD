using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace FinalApi.Controllers
{
    public class LabourController : ApiController
    {
        [Route("api/labour/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = LabourServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/labour/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = LabourServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/labour/update")]
        [HttpPost]
        public HttpResponseMessage Update(LabourModel l)
        {
            var data = LabourServices.Update(l);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/labour/create")]
        [HttpPost]
        public HttpResponseMessage Create(LabourModel l)
        {
            var data = LabourServices.Create(l);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/labour/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = LabourServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}