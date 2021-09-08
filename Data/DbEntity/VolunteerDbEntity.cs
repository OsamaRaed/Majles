using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class VolunteerDbEntity : BaseDbEntity
    {
        [Key]
        public string UserName{ get; set; }
        public string Name { get; set; }
        public List<MajlesVolunteerDbEntity> MajlesVolunteers { get; set; }
        public List<VolunteerPhoneDbEntity> VolunteerPhones { get; set; }
    }
}
