using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.Models
{
    public class Singer
    {
        [Key]
        public int SingerID { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Singer Name")] 
        public string SingerName { get; set; }
        [StringLength(10)]
        [DisplayName("Singer Birth")]
        public string SingerBirth { get; set; }
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company Company { get; set; }

    }
}
