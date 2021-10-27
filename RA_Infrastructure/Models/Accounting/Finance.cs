using RA_Infrastructure.Models.Base;
using RA_Infrastructure.Models.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Accounting
{
    [Table("Finance", Schema = "Finance")]

    public class Finance : BaseModel
    {
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        [Column(TypeName = "int")]
        public int FinanceType { get; set; }
        [Column(TypeName = "int")]
        public int BillNumber { get; set; }
        [Column( TypeName = "decimal(20,3)")]
        public double Value { get; set; }

        [ForeignKey(nameof(Residence))]
        public int ResidenceId { get; set; }

        public Residence Residence { get; set; }


    }
}
