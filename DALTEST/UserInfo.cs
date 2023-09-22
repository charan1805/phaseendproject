using DALTEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest
{
    public partial class UserInfo
    {
        public int UserId { get; set; }

        public string Email { get; set; } = null;

        public string Password { get; set; } = null;

        public virtual ICollection<CustLogInfo> CustLogInfos { get; set; } = new List<CustLogInfo>();
    }
}
