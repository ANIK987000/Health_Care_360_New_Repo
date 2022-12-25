using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StaffDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Please enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Please enter phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "*Please enter address")]

        public string Address { get; set; }

        [Required(ErrorMessage = "*Please enter salary")]
        public string Salary { get; set; }
    }
}
