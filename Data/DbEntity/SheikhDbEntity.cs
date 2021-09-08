using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class SheikhDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<SheikhPhoneDbEntity> SheikhPhones { get; set; }
        public List<MajlesDbEntity> Majles { get; set; }

    }
}
