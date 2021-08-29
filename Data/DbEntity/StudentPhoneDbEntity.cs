using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class StudentPhoneDbEntity : PhoneDbEntity
    {
        public StudentDbEntity Student { get; set; }
        public int StudentId { get; set; }
    }
}
