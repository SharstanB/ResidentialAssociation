using RA_Infrastructure.Models.Accounting;
using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA_Infrastructure.Models.Main
{
    [Table("PropertyMember", Schema = "Main")]
    public class PropertyMember : BaseModel
    {
        [Column(TypeName = "datetime2")]
        public DateTime Date { set; get; }
        [Column(TypeName = "int")]
        public int DecisionNumber { set; get; }

        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        public Property Property { get; set; }

        [ForeignKey(nameof(FirstSide))]
        public int FirstSideId { get; set; }

        public Member FirstSide { get; set; }

        [ForeignKey(nameof(SecondSide))]
        public int SecondSideId { get; set; }

        public Member SecondSide { get; set; }


        public ICollection<Finance> Finances { get; set; } 
    }
}
