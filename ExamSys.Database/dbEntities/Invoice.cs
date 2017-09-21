using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{



    public class Invoice : Properties
    {
        [Key]
        public int Id { get; set; }
        public double Rs { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Valid { get; set; }

        public InvoiceType InvoiceType { get; set; }
        
        
        public Invoice(USER user)
        {
            Valid = true;
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
        
    }

    public class InvoiceType : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }


        public InvoiceType(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }


}
