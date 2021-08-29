using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class AttendenceDbEntity
    {
        public int StudentId { get; set; }
        public StudentDbEntity Student { get; set; }
        public int LectureId { get; set; }
        public int LectureMajlesId { get; set; }
        public LectureDbEntity Lecture { get; set; }
    }
}
