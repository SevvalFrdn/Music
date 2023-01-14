using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class MusicType
    {
        [Key]
        public int MusicTypeID { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Music Type Name")]
        public string MusicTypeName { get; set; }
    }
}
