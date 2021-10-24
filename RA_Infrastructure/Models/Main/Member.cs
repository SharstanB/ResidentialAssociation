using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Main
{
    [Table("Member", Schema = "Main")]
    public class Member: BaseModel
    {
        [Column(TypeName = "int")]
        public int Member_ID { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime AffiliationDate { get; set; } //تاريخ انتساب
        [Column(TypeName = "int")]
        public int SessionNumber { get; set; }
        [Column(TypeName = "int")]
        public int DesisionNumber { get; set; }
        [Column(TypeName = "int")]
        public int CardNumber { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime MembershipExpiryDate { set; get; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }

        public Person Person { get; set; }



    }
}
