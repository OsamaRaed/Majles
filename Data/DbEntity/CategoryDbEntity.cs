using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class CategoryDbEntity : BaseDbEntity
    {
        [Key]
        public string Name { get; set; }
        public List<BookCategoryDbEntity> BookCategories { get; set; }
    }
}
