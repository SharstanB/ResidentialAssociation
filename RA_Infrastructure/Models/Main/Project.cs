using RA_Infrastructure.Models.Base;
using RA_Infrastructure.Models.Main;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA_Infrastructure.Models
{
    [Table("Project", Schema = "Main")]
    public class Project : BaseModel
    {
        [Column("ExpectedPrice", TypeName ="decimal(20,3)")]
        public double ExpectedCost { get; set; }
        [Column( TypeName = "nvarchar(50)")]
        public string Name { set; get; }
        [Required]
        public int Project_ID { set; get; }
        [Column(TypeName = "nvarchar(200)")]
        public string ProjectRegion { set; get; }
        [Column(TypeName = "nvarchar(200)")]
        public string ProjectCategory { set; get; }

        public ICollection<Residence> Residences { get; set; }

    }
}
