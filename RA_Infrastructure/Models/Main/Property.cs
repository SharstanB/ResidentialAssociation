using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Main
{
    [Table("Property", Schema = "Main")]
    public class Property: BaseModel
    {
        [Column(TypeName = "datetime2")]
        public DateTime Date { set; get; }
        [Column(TypeName = "int")]
        public int DecisionNumber { set; get; }

        [ForeignKey(nameof(Residence))]
        public int ResidenceId { get; set; }

        public Residence Residence { get; set; }

        [ForeignKey(nameof(FirstSide))]
        public int FirstSideId { get; set; }

        public Member FirstSide { get; set; }

        [ForeignKey(nameof(SecondSide))]
        public int SecondSideId { get; set; }

        public Member SecondSide { get; set; }

    }


}
