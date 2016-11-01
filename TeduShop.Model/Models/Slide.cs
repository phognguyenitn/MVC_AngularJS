using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Slide")]
    class Slide
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        //Sua lai Image
        public string Image { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        //Status dang bit
    }
}
