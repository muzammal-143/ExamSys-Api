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
        
        public DbSet<Comment>                   Comment                 { get; set; }
        public DbSet<Course>                    Course                  { get; set; }
        public DbSet<DayTiming>                 DayTiming               { get; set; }
        public DbSet<Degree>                    Degree                  { get; set; }
        public DbSet<Department>                Department              { get; set; }
        public DbSet<Role>                      Role                    { get; set; }
        public DbSet<Grades>                    Grade                   { get; set; }
        public DbSet<History>                   History                 { get; set; }
        public DbSet<ResultType>                ResultType              { get; set; }
        public DbSet<Result>                    Result                  { get; set; }
        public DbSet<Result>                    Semester_Result         { get; set; }
        public DbSet<SessionCourse>             Session_Course          { get; set; }
        public DbSet<Status>                    Status                  { get; set; }
        public DbSet<Student>                   Student                 { get; set; }
        public DbSet<Task>                      Task                    { get; set; }
        public DbSet<User>                      User                    { get; set; }
    }
}
