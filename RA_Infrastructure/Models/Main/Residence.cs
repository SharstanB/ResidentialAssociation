using RA_Infrastructure.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA_Infrastructure.Models.Main
{
    [Table("Residence", Schema = "Main")]
    public class Residence : BaseModel
    {
        [Required]
        public int Residence_ID { set; get; }
        [Column(TypeName = "nvarchar(200)")]
        public string ResidenceAddress { set; get; }
        [Column(TypeName = "int")]
        public int RoomNumber { set; get; }
        [Column(TypeName = "nvarchar(100)")]
        public string SectionNumber { set; get; } //رقم المقسم
        [Column(TypeName = "int")]
        public int ResidenceType { set; get; }
        [Column(TypeName = "nvarchar(100)")]
        public string ResidenceDirection { set; get; }
        [Column(TypeName = "int")]
        public int RecordNumber { set; get; }
        [Column(TypeName = "datetime2")]
        public DateTime RecordDate { get; set; }
        [Column( TypeName = "decimal(20,3)")]
        public double ExpectedCost { get; set; }
        [Column( TypeName = "decimal(20,3)")]
        public double FinalCost { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

    }
}
