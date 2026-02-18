using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        public string? Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
