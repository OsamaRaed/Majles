using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class AuthorBookDbEntity
    {
        public int AuthorId { get; set; }
        public AuthorDbEntity Author { get; set; }
        public int BookId { get; set; }
        public BookDbEntity Book { get; set; }
    }
}
