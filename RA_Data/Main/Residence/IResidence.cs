using RA_Repositories.Main.Residence.ResidenceDTO;
using SharedKernal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main.Residence
{
    public interface IResidence
    {
        public void AddResidence();

        public bool SoftRemove(int id);

        public OperationResult<GetResidenceInfo> GetResidences();


    }
}
