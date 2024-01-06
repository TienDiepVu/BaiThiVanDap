using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuTienDiep_192.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        [DataType(DataType.Date)] 
        public DateTime DateOfBirth { get; set; }
    }
}
