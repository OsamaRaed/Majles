using Majles.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class StudentDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string RegionId { get; set; }
        public RegionDbEntity Region { get; set; }
    }
}
