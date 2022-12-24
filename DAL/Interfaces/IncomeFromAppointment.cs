using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IncomeFromAppointment<CLASS,ID>
    {
        List<CLASS> GetIncomeFromAppointment(ID id);
    }
}
