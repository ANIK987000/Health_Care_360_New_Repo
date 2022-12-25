using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class MedicalStore
    {
        public int ID { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public string SaleAmount { get; set; }
    }
}
