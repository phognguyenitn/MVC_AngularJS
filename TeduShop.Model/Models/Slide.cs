using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Slide")]
    class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Description { get; set;}
        //Sua lai Image
        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(256)]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        
        public bool Status { set; get; }
    }
}
