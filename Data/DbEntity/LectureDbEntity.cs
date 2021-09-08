using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class LectureDbEntity : BaseDbEntity
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int MajlesId { get; set; }
        public MajlesDbEntity Majles { get; set; }
        public string Title { get; set; }
        public string MosqeName { get; set; }
        public MosqeDbEntity Mosqe { get; set; }
    }
}
