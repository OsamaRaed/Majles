using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class LectureDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public int MajlesId { get; set; }
        public MajlesDbEntity Majles { get; set; }
        public string Title { get; set; }
        public int MosqeId { get; set; }
        public MosqeDbEntity Mosqe { get; set; }
    }
}
