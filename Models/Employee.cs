using System.ComponentModel.DataAnnotations;

namespace FinalMockAssessment6.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
