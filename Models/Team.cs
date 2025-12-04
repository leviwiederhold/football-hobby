using System.ComponentModel.DataAnnotations;

namespace FootballHobby.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [StringLength(50)]
        public string Conference { get; set; } = string.Empty; // AFC or NFC

        [StringLength(50)]
        public string Division { get; set; } = string.Empty; // AFC West, NFC North, etc.

        [StringLength(100)]
        public string HeadCoach { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Player>? Players { get; set; }
    }
}
