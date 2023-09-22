using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest
{
    public partial class CustLogInfo
    {
        public int LogId { get; set; }

        public string CustEmail { get; set; } = null;

        public string CustName { get; set; } = null;

        public string LogStatus { get; set; } = null;

        public int? UserId { get; set; }

        public string Description { get; set; } = null;

        public virtual UserInfo User { get; set; }
    }
}