using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    public class PhoneDbEntity : BaseDbEntity
    {
        [Key]
        public string PhoneNumber { get; set; }
    }
}
