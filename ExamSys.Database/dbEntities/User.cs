using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    //System	1	ABCD1234	Exam	System	00000-0000000-0	1	exam@gmail.com	True	False	9/19/2017 8:29:45 AM	9/19/2017 8:29:45 AM	System
    public enum Gender 
    {
        FEMALE=0,
        MALE = 1,
    }

    public class USER : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [UniqueCNIC]
        public string CNIC { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        
        public USER(USER user)
        {
            Active = true;
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }

    }

    public class UserRole : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        // Relations
        [Key]
        public Role Role { get; set; }
        [Key]
        public USER User { get; set; }
    
        
        public UserRole(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class UserPermission : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        public DateTime expire_at { get; set; }
        // Relations
        [Key]
        public USER User { get; set; }
        [Key]
        public Permission Permission { get; set; }
        
        public UserPermission(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class UniqueCNIC : ValidationAttribute
    {
        public ExamDB db = new ExamDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                USER user = db.User.Where(m => m.CNIC == value).FirstOrDefault();
                if (user != null)
                {
                    return new ValidationResult("Error | Already exists");
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }


}
