using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Statuses 
    {
        public static void seed(ExamDB context)
        {

            

            IList<Status> Statuses = new List<Status>()
            {
                new Status()
                {
                    id = 1,
                    Title = "Active",
                    created_at = DateTime.Now ,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 2,
                    Title = "Probation",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 3,
                    Title = "Drop",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 4,
                    Title = "SemesterFreeze",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 5,
                    Title = "Block",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 6,
                    Title = "DegreeComplete",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                },
                new Status()
                {
                    id = 7,
                    Title = "CourseClear",
                    created_at = DateTime.Now,
                    edited_at = DateTime.Now
                }

            };
            foreach (var item in Statuses)
                context.Statuses.Add(item);

            context.SaveChanges();

        }

        
    }
}
