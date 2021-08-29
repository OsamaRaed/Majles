using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class MajlesStudentDbEntity
    {
        public int MajlesId { get; set; }
        public MajlesDbEntity Majles { get; set; }
        public int StudentId { get; set; }
        public StudentDbEntity Student { get; set; }

    }
}
