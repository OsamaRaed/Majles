using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class BookMajlesDbEntity
    {
        public int BookId { get; set; }
        public BookDbEntity Book { get; set; }
        public int MajlesId { get; set; }
        public MajlesDbEntity Majles { get; set; }

    }
}
