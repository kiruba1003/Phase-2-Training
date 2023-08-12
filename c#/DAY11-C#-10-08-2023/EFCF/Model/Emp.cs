using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Model
{
    internal class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Empno { get; set; }
        public string? Ename { get; set; }
        public string? Address { get; set; }

        [Required,DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int? Deptno { get; set; }
        public Dept? DeptnoNav { get; set; }


    }
}
