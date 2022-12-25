using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Health_Care_360_.Controllers
{
    [EnableCors("*", "*", "*")]
    public class MedicalStoreController : ApiController
    {

        [HttpPost]
        [Route("api/medical/store/data/add")]
        //[ValidateModel]
        public HttpResponseMessage Register(MedicalStoreDTO medicalStoreDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = MedicalStoreService.Add(medicalStoreDTO);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }




        [HttpGet]
        [Route("api/medical/store/data/list")]
        public HttpResponseMessage GetAllMedicalStoreData()
        {
            try
            {
                var data = MedicalStoreService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        [HttpGet]
        [Route("api/medical/store/data/{id}")]
        public HttpResponseMessage GetSinglMedicalStoreData(int id)
        {
            try
            {
                var data = MedicalStoreService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/medical/store/data/delete/{id}")]
        public HttpResponseMessage DeleteMedicalStoreData(/*DoctorDTO doctor*/ int id)
        {
            try
            {
                var data = MedicalStoreService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/medical/store/data/update")]
        public HttpResponseMessage UpdateMedicalStoreData(MedicalStoreDTO medicalStoreDTO)
        {
            try
            {
                var data = MedicalStoreService.Update(medicalStoreDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }
    }
}
