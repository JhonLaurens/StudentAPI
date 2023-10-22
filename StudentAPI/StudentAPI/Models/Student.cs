using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Student
    {
        //StudentId, Name, ContactNumber, Age
        //Primary Key
        [Key]
        public int StudentId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = ""; 
        

        public int ContactNumber { get; set; }

        public int Age { get; set; }
    }
}
