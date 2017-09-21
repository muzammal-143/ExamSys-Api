using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database
{
    public class ExamDB : DbContext
    {

        //Activity
        public DbSet<Activity> Activity { get; set; }

        //Comment
        public DbSet<Comment> Comment { get; set; }

        //Course
        public DbSet<Course> Course { get; set; }

        //DayTime
        public DbSet<DayTime> DayTime { get; set; }

        //Degree
        public DbSet<DegreeLevel> DegreeLevel { get; set; }
        public DbSet<Degree> Degree { get; set; }

        //Department
        public DbSet<Department> Department { get; set; }

        //Faculty
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<FacultyCourse> FacultyCourse { get; set; }

        //File
        public DbSet<File> File { get; set; }

        //Grade
        public DbSet<GradeRule> GradeRule { get; set; }
        public DbSet<Grade> Grade { get; set; }

        //History
        public DbSet<History> History { get; set; }

        //Invoice
        public DbSet<InvoiceType> InvoiceType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }

        //Notification
        public DbSet<Notification> Notification { get; set; }

        //Permission
        public DbSet<Permission> Permission { get; set; }

        //Post
        public DbSet<Post> Post { get; set; }

        //Result
        public DbSet<Result> Result { get; set; }

        //ResultType
        public DbSet<ResultType> ResultType { get; set; }

        //Role
        public DbSet<Role> Role { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }

        //Session
        public DbSet<Session> Session { get; set; }
        public DbSet<SessionDegree> SessionDegree { get; set; }
        public DbSet<SessionDegreeCourse> SessionDegreeCourse { get; set; }
        public DbSet<SessionDepartment> SessionDepartment { get; set; }
        public DbSet<SessionDepartmentDegree> SessionDepartmentDegree { get; set; }

        //Sheet
        public DbSet<Sheet> Sheet { get; set; }
        public DbSet<SheetMarks> SheetMarks { get; set; }
        public DbSet<SheetApprove> SheetApprove { get; set; }

        //Student
        public DbSet<Student> Student { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<StudentDegree> StudentDegree { get; set; }
        public DbSet<StudentSession> StudentSession { get; set; }
        public DbSet<StudentAddCourse> StudentAddCourse { get; set; }
        public DbSet<StudentResit> StudentResit { get; set; }

        //TASK
        public DbSet<TASK> TASK { get; set; }
        public DbSet<TASKStatus> TaskStatus { get; set; }
        public DbSet<TaskAssign> TaskAssign { get; set; }

        //User
        public DbSet<USER> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }

    }
}
