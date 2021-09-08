using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class MosqeDbEntity : BaseDbEntity
    {
        [Key]
        public string Name { get; set; }

        public List<MajlesDbEntity> Majles { get; set; }
        public List<LectureDbEntity> Lectures { get; set; }

    }
}
