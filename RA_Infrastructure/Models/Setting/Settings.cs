using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Setting
{
    [Table("Settings", Schema = "Setting")]
    public class Settings : BaseModel
    {
        [Column(TypeName = "decimal(20,3)")]
        public double MonthlyPremium { get; set; }

    }
}
