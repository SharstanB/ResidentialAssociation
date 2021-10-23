using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA_Infrastructure.Models.Base
{
    public class BaseModel
    {
        [Key]
        public Nullable<int> Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DeletedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
    }
}
