﻿using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        //_________________________________________
        public static IRepo<Doctor, int, Doctor> DoctorDataAccess()
        {
            return new DoctorRepo();
        }
        public static Auth<Doctor,int> DoctorAuthDataAccess()
        {
            return new DoctorRepo();
        }

        public static AuthChecker<Doctor, string> DoctorAuthCheckerDataAccess()
        {
            return new DoctorRepo();
        }
        
   
        public static QualicationCount<Doctor,string> DoctorQualicationCountDataAccess()
        {
            return new DoctorRepo();
        }

        //_______________________________________
        public static IRepo<Patient, int, Patient> PatientDataAccess()
        {
            return new PatientRepo();
        }
        public static Auth<Patient, int> PatientAuthDataAccess()
        {
            return new PatientRepo();
        }

        public static AuthChecker<Patient, string> PatientAuthCheckerDataAccess()
        {
            return new PatientRepo();
        }

        //______________________________________________
        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static Auth<Admin, int> AdminAuthDataAccess()
        {
            return new AdminRepo();
        }

        public static AuthChecker<Admin, string> AdminAuthCheckerDataAccess()
        {
            return new AdminRepo();
        }


        public static IncomeFromAppointment<Appointment, DateTime> IncomeFromAppointmentDataAccess()
        {
            return new AdminRepo();

        }

        public static IncomeFromMedicalStore<MedicalStore,DateTime> IncomeFromMedicalStoreDataAccess()
        {
            return new AdminRepo();
        }
        //_____________________________________________
        public static IRepo<Staff, int, Staff> StaffDataAccess()
        {
            return new StaffRepo();
        }
        public static Auth<Staff, int> StaffAuthDataAccess()
        {
            return new StaffRepo();
        }

        public static AuthChecker<Staff, string> StaffAuthCheckerDataAccess()
        {
            return new StaffRepo();
        }

        //__________________________________________________

        public static IRepo<NoticeBoard,int,NoticeBoard> NoticeBoardDataAccess()
        {
            return new NoticeBoardRepo();

        }

        public static IRepo<MedicalStore,int,MedicalStore> MedicalStoreDataAccess()
        {
            return new MedicalStoreRepo();
        }

        //______________________________________________________
        public static IRepo<Appointment,int,Appointment> AppointmentDataAccess()
        {
            return new AppointmentRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
        public static ListofID<Appointment,int> NewAppointmentDataAccess()
        {
            return new AppointmentRepo();
        }
        public static ListofID<Bed, int> BedListDataAccess()
        {
            return new BedRepo();
        }
        public static IRepo<PatientCheckUp, int,PatientCheckUp> PatientCheckUpDataAccess()
        {
            return new PatientCheckUpRepo();
        }
        public static IRepo<Medicine, int, Medicine> MedicineDataAccess()
        {
            return new MedicineRepo();
        }
        public static IRepo<BedAllotment, int, BedAllotment> BedAllotmentDataAccess()
        {
            return new BedAllotmentRepo();
        }
        public static IRepo<Bed, int, Bed> BedDataAccess()
        {
            return new BedRepo();
        }
        public static IRepo<BedCategory, int, BedCategory> BedCategoryDataAccess()
        {
            return new BedCategoryRepo();
        }
        public static CheckUp CheckupDataAccess()
        {
            return new PatientCheckUpRepo();
        }

        //public static IAuth AuthDataAccess()
        //{
        //    return new UserRepo();
        //}
        //public static IRepo<Token, string, Token> TokenDataAccess()
        //{
        //    return new TokenRepo();
        //}
    }
 }
