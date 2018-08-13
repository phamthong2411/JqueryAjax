using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxTable.Data.Models
{
    [Table("Employees")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [StringLength(255)]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Name { set; get; }


        public float Salary { set; get; }


        [Required]
        public DateTime CreateDate { set; get; }
        public bool Status { set; get; }

    }
}
