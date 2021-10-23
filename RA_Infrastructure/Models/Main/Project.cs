using RA_Infrastructure.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA_Infrastructure.Models
{
    [Table("ExpectedPrice", Schema = "Main")]
    public class Project : BaseModel
    {
        [Column("ExpectedPrice", TypeName ="decimal(20,3)")]
        public double ExpectedCost { get; set; }


    }
}
