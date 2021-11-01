using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main.Member.MemberDTO
{
     public class GetMemberInfo
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string MembershipNumber { get; set; }

        public string SessionNumber { get; set; }

        public int DesisionNumber { get; set; }


    }
}
