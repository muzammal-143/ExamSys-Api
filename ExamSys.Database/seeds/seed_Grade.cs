using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Grades
    {
        public static void seed(ExamDB context)
        {
            

            IList<Grade> Grades = new List<Grade>()
            {
                /*
                new Grade()
                {
                    Id = 1,
                    Lower_Range = 0,
                    Upper_Range = 49,
                    Points = 0,
                    grade = "F",
                },
                new Grade()
                {
                    Id = 2,
                    Lower_Range = 50,
                    Upper_Range = 52,
                    Points = 1.0,
                    grade = "D"
                },
                new Grade()
                {
                    Id = 3,
                    Lower_Range = 53,
                    Upper_Range = 56,
                    Points = 1.33,
                    grade = "D+"
                },
                new Grade()
                {
                    Id = 4,
                    Lower_Range = 57,
                    Upper_Range = 59,
                    Points = 1.66,
                    grade = "C-"
                },
                new Grade()
                {
                    Id = 5,
                    Lower_Range = 60,
                    Upper_Range = 63,
                    Points = 2.0,
                    grade = "C"
                },
                new Grade()
                {
                    Id = 6,
                    Lower_Range = 63,
                    Upper_Range = 66,
                    Points = 2.33,
                    grade = "C+"
                },
                new Grade()
                {
                    Id = 7,
                    Lower_Range = 67,
                    Upper_Range = 69,
                    Points = 2.66,
                    grade = "B-"
                },
                new Grade()
                {
                    Id = 8,
                    Lower_Range = 70,
                    Upper_Range = 74,
                    Points = 3.00,
                    grade = "B"
                },
                new Grade()
                {
                    Id = 9,
                    Lower_Range = 75,
                    Upper_Range = 79,
                    Points = 3.33,
                    grade = "B+"
                },
                new Grade()
                {
                    Id = 10,
                    Lower_Range = 80,
                    Upper_Range = 84,
                    Points = 3.66,
                    grade = "A"
                },new Grade()
                {
                    Id = 11,
                    Lower_Range = 85,
                    Upper_Range = 100,
                    Points = 4.0,
                    grade = "A+"
                },
                 */ 
            };
            foreach (var item in Grades)
                context.Grade.Add(item);

            context.SaveChanges();

        }
    }
}
