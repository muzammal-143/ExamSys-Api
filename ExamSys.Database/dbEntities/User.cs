using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class User : Properties
    {
        public int id { get; set; }
        [UniqueCNIC]
        public string CNIC { get; set; }
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public UserStudent UserStudent
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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

        public Role Role
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public User User
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
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

        public Permission Permission
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public User User
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public UserPermission()
        {
            new Properties();
        }
        public UserPermission(User user)
        {
            new Properties(user);
        }
    }

    public enum StudentAddCourse_Type
    {
        SEMESTER,
        SUMMER,
    }



}
