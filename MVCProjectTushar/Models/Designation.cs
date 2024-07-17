using System.ComponentModel.DataAnnotations;

namespace MVCProjectTushar.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ? DesignationName { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
