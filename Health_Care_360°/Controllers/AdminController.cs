using BLL.DTOs;
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
    public class AdminController : ApiController
    {
        
        [HttpPost]
        [Route("api/admin/add")]
        //[ValidateModel]
        public HttpResponseMessage Register(AdminDTO admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = AdminService.Add(admin);
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
        [Route("api/admin/list")]
        public HttpResponseMessage GetAllAdmins()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage GetSinglAdmin(int id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/admin/delete/{id}")]
        public HttpResponseMessage DeleteAdmin(/*DoctorDTO doctor*/ int id)
        {
            try
            {
                var data = AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/admin/update")]
        public HttpResponseMessage UpdateAdmin(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Update(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        //________________________________________________

        [HttpGet]
        [Route("api/all/list/count")]
        public HttpResponseMessage AllDoctorsCount()
        {
            try
            {
                
                var data = DoctorService.Get().Count;
                var data1 = PatientService.Get().Count;
                var data2 = StaffService.Get().Count;
                var data3=AdminService.Get().Count;
                var data4=NoticeBoardService.Get().Count;
                var data5 = AdminService.GetIncomeFromAppointment(DateTime.Today).Count;

                var data6=data+data1+data2+data3;

                List<int> numberList = new List<int>() { data, data1, data2,data3,data4,data5,data6 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //______________________________________________

        [HttpGet]
        [Route("api/doctor/count/by/qual")]
        public HttpResponseMessage GetDoctorCountByQualification()
        {
            try
            {
                var data1 = DoctorService.GetDoctorCountByQualification("Surgeon").Count;
                var data2 = DoctorService.GetDoctorCountByQualification("Dermatologist").Count;
                var data3 = DoctorService.GetDoctorCountByQualification("Orthopedist").Count;
                var data4 = DoctorService.GetDoctorCountByQualification("Urologist").Count;
                var data5 = DoctorService.GetDoctorCountByQualification("Neurologist").Count;
                var data6 = DoctorService.GetDoctorCountByQualification("Orthodontist").Count;
                var data7 = DoctorService.GetDoctorCountByQualification("Anesthesiologist").Count;
                var data8 = DoctorService.GetDoctorCountByQualification("Cardiology physician").Count;
            
                List<int> numberList = new List<int>() {data1, data2, data3, data4, data5,data6,data7,data8 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //___________________________________________________________________

        [HttpGet]
        [Route("api/income/from/appointment/for/today")]
        public HttpResponseMessage GetIncomeFromAppointmentForToday()
        {
            try
            {
                //var dt = DateTime.Today.ToString() ;
                var data1 = AdminService.GetIncomeFromAppointment(DateTime.Today);
                int count1 = 0;
                foreach (var income in data1)
                {
                    count1 += Int32.Parse(income.AppointmentFee);
                }



                var data2 = AdminService.GetIncomeFromMedicalStore(DateTime.Today);
                int count2 = 0;
                foreach (var income in data2)
                {
                    count2 += Int32.Parse(income.SaleAmount);
                }

                int count=count1+ count2;
                List<int> numberList = new List<int>() { count };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //________________________________________________________________

        [HttpGet]
        [Route("api/income/from/appointment/for/last/seven/days")]
        public HttpResponseMessage GetIncomeFromAppointmentForLastSevenDays()
        {
            try
            {
                //var dt = DateTime.Today.ToString() ;
                var data = AdminService.GetIncomeFromAppointment(DateTime.Today);
                var data1 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-1));
                var data2 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-2));
                var data3 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-3));
                var data4 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-4));
                var data5 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-5));
                var data6 = AdminService.GetIncomeFromAppointment(DateTime.Today.AddDays(-6));
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                int count5 = 0;
                int count6 = 0;
                foreach (var income in data)
                {
                    count += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data1)
                {
                    count1 += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data2)
                {
                    count2 += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data3)
                {
                    count3 += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data4)
                {
                    count4 += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data5)
                {
                    count5 += Int32.Parse(income.AppointmentFee);
                }
                foreach (var income in data6)
                {
                    count6 += Int32.Parse(income.AppointmentFee);
                }
             

                List<int> numberList = new List<int>() { count, count1, count2, count3, count4, count5, count6 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //________________________________________________________________



        [HttpGet]
        [Route("api/income/from/medical/store/for/last/seven/days")]
        public HttpResponseMessage GetIncomeFromMedicalStoreForLastSevenDays()
        {
            try
            {
                //var dt = DateTime.Today.ToString() ;
                var data = AdminService.GetIncomeFromMedicalStore(DateTime.Today);
                var data1 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-1));
                var data2 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-2));
                var data3 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-3));
                var data4 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-4));
                var data5 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-5));
                var data6 = AdminService.GetIncomeFromMedicalStore(DateTime.Today.AddDays(-6));
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                int count5 = 0;
                int count6 = 0;
                foreach (var income in data)
                {
                    count += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data1)
                {
                    count1 += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data2)
                {
                    count2 += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data3)
                {
                    count3 += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data4)
                {
                    count4 += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data5)
                {
                    count5 += Int32.Parse(income.SaleAmount);
                }
                foreach (var income in data6)
                {
                    count6 += Int32.Parse(income.SaleAmount);
                }


                List<int> numberList = new List<int>() { count, count1, count2, count3, count4, count5, count6 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }




        //_____________________________________________________________________

        [HttpGet]
        [Route("api/admin/get/{email}")]
        public HttpResponseMessage GetSingleAdminByEmail(string email)
        {
            try
            {
                var data = AdminService.GetChecker(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }






    }
}
