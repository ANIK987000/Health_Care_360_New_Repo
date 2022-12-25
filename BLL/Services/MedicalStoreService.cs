using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MedicalStoreService
    {
        public static MedicalStoreDTO Add(MedicalStoreDTO medicalStoreDTO)
        {
            var config = Service.Mapping<MedicalStoreDTO, MedicalStore>();
            var mapper = new Mapper(config);
            var data = mapper.Map<MedicalStore>(medicalStoreDTO);
            var repo = DataAccessFactory.MedicalStoreDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<MedicalStoreDTO>(repo);
            }
            return null;
        }
        public static List<MedicalStoreDTO> Get()
        {
            var data = DataAccessFactory.MedicalStoreDataAccess().Get();
            //var config= Service.OneTimeMapping<Doctor, DoctorDTO>();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MedicalStore, MedicalStoreDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<MedicalStoreDTO>>(data);
        }
        public static MedicalStoreDTO Get(int id)
        {
            var data = DataAccessFactory.MedicalStoreDataAccess().Get(id);
            var config = Service.OneTimeMapping<MedicalStore, MedicalStoreDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<MedicalStoreDTO>(data);
        }


        public static bool Delete(/*DoctorDTO doctorDTO*/ int id)
        {
            //var config = Service.OneTimeMapping<Doctor, DoctorDTO>();
            //var mapper = new Mapper(config);
            //var doctor = mapper.Map<Doctor>(doctorDTO);
            var data = DataAccessFactory.MedicalStoreDataAccess().Delete(/*doctor*/ id);
            return data;

        }


        public static MedicalStoreDTO Update(MedicalStoreDTO medicalStoreDTO)
        {
            var config = Service.Mapping<Admin, MedicalStoreDTO>();
            var mapper = new Mapper(config);
            var medicalStore = mapper.Map<MedicalStore>(medicalStoreDTO);
            var data = DataAccessFactory.MedicalStoreDataAccess().Update(medicalStore);
            if (data != null)
            {
                return mapper.Map<MedicalStoreDTO>(data);
            }

            return null;

        }


    }
}
