using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dbBackend.Models
{
    public partial class User
    {
        public User()
        {

        }
        public User(int id, string fn, string ln, string em, string ph, string addr, string st, string ct, string pn)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
            Email = em;
            Phone = ph;
            EmailAddressAttribute = addr;
            State = st;
            City = ct;
            PinCode = pn;

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "serial")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public States State { get; set; }
        [DisplayFormat(NullDisplayText = "Null name")]
        public string LastName { get; set; }

        [DisplayFormat(NullDisplayText = "Null name")]
        public string FirstName { get; set; }

        [ForeignKey("Id")]
        public Cities City;

        public string Address;

        public string Phone;

        public string Email;

        public virtual States StatesNavigation { get; set; }
    }
}
