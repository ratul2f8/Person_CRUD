using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInfo.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Bloodgroup { get; set; }

        [Required]
        public int Age { get; set; }

    }
}
