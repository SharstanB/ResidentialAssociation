using RA_Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA_Infrastructure.Models.Main
{
    [Table("Person", Schema = "Main")]
    public class Person:BaseModel
    {
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { set; get; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { set; get; }

        [Column(TypeName = "nvarchar(50)")]
        public string FatherName { set; get; }

        [Column(TypeName = "nvarchar(50)")]
        public string MotherName { set; get; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BirthPlace { set; get; }

        [Column(TypeName = "int")]
        public int SocialStatus { set; get; }

        [Column(TypeName = "int")]
        public int RegistrationNumber { set; get; }

        [Column(TypeName = "bit")]
        public bool IsMarried { set; get; }

        [Column(TypeName = "int")]
        public int Gender { set; get; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address { set; get; }

        [Column(TypeName = "nvarchar(50)")]
        public string JobAddress { set; get; }

        [Column(TypeName = "decimal(15,5)")]
        public int Income { set; get; }

        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }

        public Member Member { get; set; }



    }
}
