using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Finance
{
    public class Finance : BaseModel
    {
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int ResolutionNumber { get; set; }

    }
}
