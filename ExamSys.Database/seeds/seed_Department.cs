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
                   
                },
            };
            foreach (var item in Departments) db.Department.Add(item);

            db.SaveChanges();

        }
    }
}
