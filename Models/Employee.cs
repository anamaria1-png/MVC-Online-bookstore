using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_bookstore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Display(Name = "Birth  Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string? Job { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
    }
}
