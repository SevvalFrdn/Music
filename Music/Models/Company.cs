using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [StringLength(35)]
        [DisplayName("Company Manager")]
        public string CompanyManager { get; set; }
        [Required]
        [DisplayName("Company Phone")]
        public string CompanyPhone { get; set; }
        [DisplayName("Company Address")]
        public string CompanyAddress { get; set; }
    }
}
