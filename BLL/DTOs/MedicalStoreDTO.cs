using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MedicalStoreDTO
    {
        public int ID { get; set; }

        public DateTime CreateDate { get; set; }

        public string SaleAmount { get; set; }
    }
}
