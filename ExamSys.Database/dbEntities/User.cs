using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum Gender 
    {
        FEMALE=0,
        MALE = 1,
    }

    public class User : Properties
    {
        public int id { get; set; }
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

        public User()
        {
            Active = true;
            new Properties();
        }
        public User(User user)
        {
            Active = true;
            new Properties(user);
        }

    }

    public class UserRole : Properties
    {
        public int Id { get; set; }
        // Relations
        [Key]
        public Role Role { get; set; }
        [Key]
        public User User { get; set; }
    
        public UserRole()
        {
            new Properties();
        }
        public UserRole(User user)
        {
            new Properties(user);
        }
    }

    public class UserPermission : Properties
    {
        public int id { get; set; }
        public DateTime expire_at { get; set; }
        // Relations
        [Key]
        public User User { get; set; }
        [Key]
        public Permission Permission { get; set; }
        public UserPermission()
        {
            new Properties();
        }
        public UserPermission(User user)
        {
            new Properties(user);
        }
    }

    public class UniqueCNIC : ValidationAttribute
    {
        //public ExamDB db = new ExamDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                User user = db.User.Where(m => m.CNIC == value).FirstOrDefault();
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
