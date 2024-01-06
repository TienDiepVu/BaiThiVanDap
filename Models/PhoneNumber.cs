using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuTienDiep_192.Models
{
    [Table("PhoneNumber")]
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberID { get; set; }
        
        public string PhoneNumberValue { get; set; }

        public string PersonID { get; set; }
        
        [ForeignKey("PersonID")]
        public Person Person { get; set; }
    }
}
