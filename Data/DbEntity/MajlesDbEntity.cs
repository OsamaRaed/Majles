using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class MajlesDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public int SheikhId { get; set; }
        public SheikhDbEntity Sheikh { get; set; }
        public string MosqeName { get; set; }
        public MosqeDbEntity Mosqe { get; set; }
        public List<BookMajlesDbEntity> BookMajles { get; set; }
        public List<MajlesStudentDbEntity> MajlesStudents { get; set; }
        public List<MajlesVolunteerDbEntity> MajlesVolunteers { get; set; }
        public List<LectureDbEntity> Lectures { get; set; }
    }
}
