using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("Song Name")]
        public string SongName { get; set; }
        [DisplayName("Lyrics")]
        public string Lyrics { get; set; }
        public int AlbumID { get; set; }
        [ForeignKey("AlbumID")]
        public Album Album { get; set; }
    }
}
