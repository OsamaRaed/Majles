using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class BookCategoryDbEntity
    {
        public int BookId { get; set; }
        public BookDbEntity Book { get; set; }
        public string CategoryId { get; set; }
        public CategoryDbEntity Category { get; set; }
    }
}
