using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Required]
        public string SongTitle { get; set; } = string.Empty; //Attributes for the class
        public int DurationSeconds { get; set; }


        public virtual ICollection<SongArtist>? SongArtists { get; set; } = new List<SongArtist>(); //Connects with the main song artist class
    }
}
