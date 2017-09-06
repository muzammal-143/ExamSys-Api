using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class User
    {

        [Key]
        public int id { get; set; }
        //[Index(IsUnique = true)]
        public string UserName { get; set; }
        public string Password { get; set; }

        public Designation Designation { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public bool   Active { get; set; }

        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public User()
        {
            Active = true;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
