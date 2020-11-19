using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackEndAPIs.Models;

namespace BackEndAPIs.Models
{
    public class Cities
    {
        public Cities(int id, string name)
        {
            Id = id;
            Name = name;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "serial")]
        [Key]
        public int Id { get; set; }

        [DisplayFormat(NullDisplayText = "Null name")]
        public string Name { get; set; }
        public virtual ICollection<User> User { get; set; }

    }
}
