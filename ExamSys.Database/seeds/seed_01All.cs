using ExamSys.Database.dbEntities;
using ExamSys.Database.seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_All
    {
        ExamDB db = new ExamDB();
        public void start() 
        {

            //Activity
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Activitys");
            //Comment
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Comments");
            //Course
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Courses");
            //DayTime
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE DayTimes");
            //Degree
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Degrees");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE DegreeLevels");
            //Department
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Departments");
            //Faculty
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Facultys");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE FacultyCourses");
            //File
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Files");
            //Grade
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Grades");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE GradeRules");
            //History
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Historys");
            //Invoice
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Invoices");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE InvoiceTypes");
            //Notification
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Notifications");
            //Permission
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Permissions");
            //Post
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Posts");
            //Result
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Results");
            //ResultType
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE ResultTypes");
            //Role
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Roles");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE RolePermissions");
            //Session
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Sessions");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SessionDegrees");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SessionDegreeCourses");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SessionDepartments");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SessionDepartmentDegrees");
            //Sheet
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Sheets");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SheetMarkss");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE SheetApproves");
            //Student
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Students");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Registrations");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE StudentCourses");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE StudentDegrees");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE StudentSessions");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE StudentAddCourses");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE StudentResits");
            //TASK
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE TASKs");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE TaskStatuss");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE TaskAssigns");
            //User
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE Users");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE UserRoles");
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE UserPermissions");

            db.SaveChanges();

            User user = new User()
            {
                Id = 1,
                UserName = "System",
                Password = "ABCD1234",
                FirstName = "System",
                LastName = "Exam",
                CNIC = "00000-0000000-0",
                Email = "SU.ExamSystem@gmail.com",
                Active = true,
                Gender = Gender.MALE

            };
            seed_User.seed(db);

            
        }
    }
}
