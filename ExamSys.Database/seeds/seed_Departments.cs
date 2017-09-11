using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    class seed_Departments : DropCreateDatabaseAlways<ExamDB>
    {
        public static void seed(ExamDB db)
        {
            

            IList<Department> Departments = new List<Department>()
            {
                new Department()
                {
                    id = 1,
                    Degree = db.Degree.Find(1),
                    DayTiming = db.DayTiming.Find(1),
                    Description = "Computer Science",
                    Title = "BSCS",
                    TotalSemesters =  8,
                    Color = "GREEN"
                },
                new Department()
                {
                    id = 2,
                    Degree = db.Degree.Find(1),
                    DayTiming = db.DayTiming.Find(2),
                    Description = "Business Administration",
                    Title = "BBA",
                    TotalSemesters =  8,
                    Color = "RED",
                },
            };
            foreach (var item in Departments) db.Department.Add(item);

            db.SaveChanges();

        }
    }
}
