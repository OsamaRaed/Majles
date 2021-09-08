using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class BookDbEntity : BaseDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCategoryDbEntity> BookCategories { get; set; }
        public List<AuthorBookDbEntity> AuthorBooks { get; set; }
        public List<BookMajlesDbEntity> BookMajles { get; set; }
    }
}
