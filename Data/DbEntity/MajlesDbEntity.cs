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
        public int MosqeId { get; set; }
        public MosqeDbEntity Mosqe { get; set; }
    }
}
