using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class AuthorDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
