using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rollno { get; set; }
        [Required]
        public string? Studentame { get; set; }
        [Required]
        public string? Addr { get; set; }
        [Required]
        public long phno { get; set; }
    }
}
