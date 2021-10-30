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
        [Column( TypeName = "nvarchar(50)")]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Project_ID { set; get; }  


        [Column(TypeName = "nvarchar(200)")]
        public string ProjectLocation { set; get; }


       

        public ICollection<Residence> Residences { get; set; }

    }
}
