using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; //Attributes for this class
        public int FollowerCount { get; set; }

        public virtual ICollection<SongArtist>? SongArtists { get; set; } = new List<SongArtist>(); //Connects with the main song artist class
    }
}
