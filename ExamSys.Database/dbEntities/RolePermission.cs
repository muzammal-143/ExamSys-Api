using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class RolePermission : Properties
    {
        public int Id { get; set; }
        [Key]
        public Role Role { get; set; }
        [Key]
        public Permission Permission { get; set; }
    }
}
