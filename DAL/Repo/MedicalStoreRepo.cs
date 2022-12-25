using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class MedicalStoreRepo : Repo, IRepo<MedicalStore, int, MedicalStore>
    {
        public MedicalStore Add(MedicalStore obj)
        {
            db.MedicalStores.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.MedicalStores.Find(id);
            db.MedicalStores.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<MedicalStore> Get()
        {
            return db.MedicalStores.ToList();
        }

        public MedicalStore Get(int id)
        {
            return db.MedicalStores.Find(id);
        }

        public MedicalStore Update(MedicalStore obj)
        {
            var data = Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
