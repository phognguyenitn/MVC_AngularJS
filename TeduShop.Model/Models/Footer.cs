using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    //using System.ComponentModel.DataAnnotations.Schema
    [Table("Footers")]
    public class Footer
    {
        //using System.ComponentModel.DataAnnotations;
        [Key]
        public string ID { get; set; }

        //using System.ComponentModel.DataAnnotations;
        [Required]
        public string Content { get; set; }
    }
}