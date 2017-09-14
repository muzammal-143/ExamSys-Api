using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Degree : Properties
    {
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public int Years { get; set; }
        public int TotalSemesters { get; set; }

        

        public SessionDegree SessionDegree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DepartmentDegree DepartmentDegree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public Degree()
        {
            new Properties();
        }
        public Degree(User user)
        {
            new Properties(user);
        }
    }
    
}
