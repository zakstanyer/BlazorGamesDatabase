using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppGames.Models
{
    public class Game
    {
        public int Id { get; set; }

        //max length = 50
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Title { get; set; }

        public DateOnly ReleaseDate { get; set; }

        //limit the genre to just characters A-Z, as well as brackets, spaces and dashes
        [Required]
        [StringLength (50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
        public string? Genre { get; set; }

        //limit to 2 decimal place
        [Range(0, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
        //score must be 10 or between 0 and 9, or N/A
        [Required]
        [RegularExpression(@"[1][0]|[0-9]|N/A")]
        public string? Score { get; set; }
    }
}
