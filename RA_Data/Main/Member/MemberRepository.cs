using RA_Repositories.Base;
using RA_Repositories.Main.Member.MemberDTO;
using RA_SqlSever;
using SharedKernal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main
{
    public class MemberRepository : BaseRepository ,  IMemberRepository
    {

        public MemberRepository(RAContext context) :
            base(context)
        {

        }
        public void AddMember()
        {
            throw new NotImplementedException();
        }

      
        public bool SoftRemove(int id)
        {
            throw new NotImplementedException();
        }

        public  OperationResult<GetMemberInfo> GetMembers()
        {
            OperationResult<GetMemberInfo> result 
                = new OperationResult<GetMemberInfo>();
            try
            {
                result.ResultList = Context.Members.Where(member => member.DeletedDate == null).
                              Select(member => new GetMemberInfo()
                              {
                                  DesisionNumber = member.DesisionNumber,
                                  Id = member.Id.Value,
                                  FullName = $"{member.Person.FirstName} {member.Person.LastName}",

                              }).ToList();
            }
            catch(Exception ex)
            {
                result.Exception = ex;
            }
          
            return result;
        }
    }
}
