using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Repositories.Main.Residence.ResidenceDTO
{
    public class GetResidenceInfo
    {
        public int Id { get; set; }

        public string ResidenceAddress { get; set; }

        public int RoomNumber { get; set; }

        public int FloorNumber { get; set; }
      
        public int RecordNumber { get; set; }
        
        public int ExpectedCost { get; set; }
        
        public int FinalCost { get; set; }


    }
}
