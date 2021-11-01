using RA_Repositories.Main.Member.MemberDTO;
using SharedKernal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main
{
    public interface IMemberRepository
    {
        public void AddMember();

        public bool SoftRemove(int id);

        public OperationResult<GetMemberInfo> GetMembers();
    }
}
