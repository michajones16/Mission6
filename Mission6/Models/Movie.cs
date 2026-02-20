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
        [Required(ErrorMessage = "Please enter a movie title")]
        public string Title { get; set; }
        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string Rating { get; set; }
        [Required(ErrorMessage = "Please select Yes or No under \"Edited\"")]
        public string Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Please select Yes or No under \"Copied to Plex\"")]
        public int CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
