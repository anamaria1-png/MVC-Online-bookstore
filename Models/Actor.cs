using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_bookstore.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Display(Name = "Launch year")]
        [DataType(DataType.Date)]
        public DateTime LaunchYear { get; set; }
        public string? Role { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ReplicaNumbers { get; set; }
    }
}