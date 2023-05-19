using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CompleteProject.Data.DataModel
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpPhone { get; set; }
        public string EmpEmail { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
