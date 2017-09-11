using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Students
    {
        public static void seed(ExamDB context)
        {
            
            
            context.Student.AddOrUpdate(
                new Student()
                {
                    id = 1,                          
                    Semester = 1,
                    Session = 2016,
                    RegistrationNO = "94384711",
                    Designation = 5,
                    Gender = "Male",
                    Picture = "",
                    Status = 1,
                    Department = 1,
                    Comment = "",
                },
                new Student()
                {
                    id = 2,
                    Semester = 1,
                    Session = 2016,
                    RegistrationNo = "94344711",
                    Designation = 5,
                    Gender = "Male",
                    Picture = "",
                    Status = 1,
                    Department = 1,
                    Comment = "",
                    created_at = DateTime.Now ,
                    edited_at = DateTime.Now
                }
            );

            context.SaveChanges();

        }
    }
}
