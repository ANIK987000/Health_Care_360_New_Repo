using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoticeBoardDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter description ")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter end date")]
        public DateTime EndDate { get; set; }
    }
}
