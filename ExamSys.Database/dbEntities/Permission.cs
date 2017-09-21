using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class Permission : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        //Relations
        public Activity Activity { get; set; }

        
        public Permission(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

}
