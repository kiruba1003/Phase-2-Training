using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Model
{
    internal class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//not allowing for auto generated
        public int Deptno { get; set; }
        public string ?Dname { get; set;} //=string.Empty;

        public ICollection<Emp>? Emps { get; set; }  
    }
}
