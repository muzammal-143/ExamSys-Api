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
        [Index("Id", IsUnique = true)]
        public int id { get; set; }

        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public Role()
        {
            
        }
        
        public Role(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class RolePermission : Properties
    {

        public int id { get; set; }
        [Key]
        public Role Role { get; set; }
        [Key]
        public Permission Permission { get; set; }
    
        
        public RolePermission(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
