using System.ComponentModel.DataAnnotations;

namespace FootballHobby.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Player Name")]
        public string Name { get; set; } = string.Empty;

        [StringLength(10)]
        public string Position { get; set; } = string.Empty; // QB, RB, WR, TE, LB, CB, S, etc.

        [Range(1, 99)]
        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        // FK to NFL Team
        [Display(Name = "NFL Team")]
        public int TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
