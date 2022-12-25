﻿using BLL.DTOs;
using BLL.Services;
using Health_Care_360_.Auth;
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
    [Logged]
    public class StaffController : ApiController
    {

        [HttpPost]
        [Route("api/staff/add")]
        public HttpResponseMessage Register(StaffDTO staffDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = StaffService.Add(staffDTO);
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
        [Route("api/staff/list")]
        public HttpResponseMessage GetAllStaffs()
        {
            try
            {
                var data = StaffService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        [HttpGet]
        [Route("api/staff/{id}")]
        public HttpResponseMessage GetSingleStaff(int id)
        {
            try
            {
                var data = StaffService.Get(id);
             
                
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                //var err = "No staff found";
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/staff/delete/{id}")]
        public HttpResponseMessage DeleteStaffs(/*DoctorDTO doctor*/ int id)
        {
            try
            {
                var data = StaffService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/staff/update")]
        public HttpResponseMessage UpdateStaffs(StaffDTO staffDTO)
        {
            try
            {
                var data = StaffService.Update(staffDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpGet]
        [Route("api/staff/get/{email}")]
        public HttpResponseMessage GetSingleStaffByEmail(string email)
        {
            try
            {
                var data = StaffService.GetChecker(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }



        //_____________________________________________________________________________

        [HttpPost]
        [Route("api/staff/AddMedicine")]
        public HttpResponseMessage AddMedicine(MedicineDTO medicine)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = MedicineService.Add(medicine);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent,ex);
            }
        }
    }
}
