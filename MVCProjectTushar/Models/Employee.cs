using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProjectTushar.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ? FirstName { get; set; }

        [Required]
        public string ? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string ?EmailAddress { get; set; }
        
        [Required]
        [Phone]
        public string ?PhoneNumber { get; set; }

        [ForeignKey("Designation")]

        public int DesignationIdRef {  get; set; }
        
        public Designation ?Designation { get; set; }




    }
}
