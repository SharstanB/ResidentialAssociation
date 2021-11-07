using RA_Repositories.Base;
using RA_Repositories.Main.Residence.ResidenceDTO;
using RA_SqlSever;
using SharedKernal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main.Residence
{
    public class ResidenceRepository : BaseRepository , IResidence
    {
        public ResidenceRepository(RAContext context) :
           base(context)
        {

        }
        public void AddResidence()
        {
            throw new NotImplementedException();
        }

        public OperationResult<GetResidenceInfo> GetResidences()
        {
            throw new NotImplementedException();
        }

        public bool SoftRemove(int id)
        {
            throw new NotImplementedException();
        }
         
    }
}
