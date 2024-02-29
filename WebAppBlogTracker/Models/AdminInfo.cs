using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppBlogTracker.Models
{
    [Table("AdminInfo")]
    public class AdminInfo
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [StringLength(50)]
        public string? EmailId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
