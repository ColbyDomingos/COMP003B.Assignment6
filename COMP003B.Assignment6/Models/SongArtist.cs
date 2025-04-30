namespace COMP003B.Assignment6.Models
{
    public class SongArtist
    {
        public int Id { get; set; }
        public int SongId { get; set; } //Attributes for the class
        public int ArtistId { get; set; }

        public virtual Artist? Artist { get; set; } //These are null values that are fixed with virtual tags
        public virtual Song? Song { get; set; }
    }
}
