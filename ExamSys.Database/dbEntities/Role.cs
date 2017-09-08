using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Role : Properties
    {
        public int id { get; set; }

        //[Index(IsUnique = true)]
        public string Title { get; set; }


        public Role()
        {
        }
    }
    public class RolePermission : Properties
    {
        public int id { get; set; }
        [Key]
        public Role Role { get; set; }
        [Key]
        public Permission Permission { get; set; }
        public RolePermission()
        {
        }
    }
}
