using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Album Name")]
        public string AlbumName { get; set; }
        [StringLength(4)]
        [DisplayName("Album Year")]
        public int AlbumYear { get; set; } 
        [DisplayName("Album Price")]
        public string AlbumPrice { get; set; }
        public int MusicTypeID { get; set; }
        [ForeignKey("MusicTypeID")]
        public MusicType MusicType { get; set; }
        public int SingerID { get; set; }
        [ForeignKey("SingerID")]
        public Singer Singer { get; set; }


    }
}
