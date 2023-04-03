using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_bookstore.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        public string? Review{ get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal StarsNumber { get; set; }
    }
}