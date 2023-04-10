using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FinalApi.Auth;

namespace FinalApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class customerController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel obj)
        {
            var data = AuthServices.Authenticate(obj.email, obj.password);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [Route("api/customer/getall")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CustomerServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        //[ValidUser]
        [Route("api/customer/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = CustomerServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/update")]
        [HttpPost]
        public HttpResponseMessage Update(CustomerModel c)
        {
            var data = CustomerServices.Update(c);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel c)
        {
            var data = CustomerServices.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
        [Route("api/customer/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = CustomerServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/trip/{id}")]
        [HttpGet]
        public HttpResponseMessage getalltrip(int id)
        {
            var data = CustomerServices.GetAllTripOparetion(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/pendingtrip/{id}")]
        [HttpGet]
        public HttpResponseMessage GetPendingTrip(int id)
        {
            var data = CustomerServices.GetPendingTrip(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/confirmedtrip/{id}")]
        [HttpGet]
        public HttpResponseMessage GetConfirmedTrip(int id)
        {
            var data = CustomerServices.GetConfirmedTrip(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/finishedtrip/{id}")]
        [HttpGet]
        public HttpResponseMessage GetFinishedTrip(int id)
        {
            var data = CustomerServices.GetFinishedTrip(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/deletetrip/{id}")]
        [HttpGet]
        public HttpResponseMessage DleteTrip(int id)
        {
            var data = CustomerServices.DeleteTrip(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/createtrip")]
        [HttpPost]
        public HttpResponseMessage createTrip(TripeModel obj)
        {
            var data = CustomerServices.createTrip(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/trip")]
        [HttpGet]
        public HttpResponseMessage getalltrip()
        {
            var data = CustomerServices.getalltrip();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/customer/activitylog")]
        [HttpPost]
        public HttpResponseMessage createactyvity(ActivityLogModel obj)
        {
            var data = ActivityLogServices.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
