using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.DbEntity
{
    class SheikhPhoneDbEntity : PhoneDbEntity
    {
        public int SheikhId { get; set; }
        public SheikhDbEntity Sheikh { get; set; }

    }
}
