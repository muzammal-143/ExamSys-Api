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
        public DbSet<Degree>                    Degrees                 { get; set; }
        public DbSet<Department>                Department              { get; set; }
        public DbSet<Role>               Designation             { get; set; }
        public DbSet<Grades>                     Grade                   { get; set; }
        public DbSet<History>                   History                 { get; set; }
        public DbSet<Result_Type>               Result_Type             { get; set; }
        public DbSet<Semester_Result>   Semester_Details_Result { get; set; }
        public DbSet<Semester_Result>           Semester_Result         { get; set; }
        public DbSet<Session_Course>            Session_Course          { get; set; }
        public DbSet<Status>                    Status                  { get; set; }
        public DbSet<Student>                   Student                 { get; set; }
        public DbSet<ExamSys.Database.dbEntities.Task> Task             { get; set; }
        public DbSet<User>                      User                    { get; set; }
    }
}
