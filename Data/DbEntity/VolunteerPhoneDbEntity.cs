using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class VolunteerPhoneDbEntity : PhoneDbEntity
    {
        public int VolunteerId { get; set; }
        public VolunteerDbEntity Volunteer { get; set; }
    }
}
