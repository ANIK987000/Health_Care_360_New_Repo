using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Please enter your name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "*Please enter your email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "*Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "*Please enter your address")]
        public string Address { get; set; }
    }
}
