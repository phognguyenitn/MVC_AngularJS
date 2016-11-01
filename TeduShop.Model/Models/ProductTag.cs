using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    class ProductTag
    {
        [Key]
        [Foreign("ProductID")]
        public int ProductID { set; get; }
        [Key]
        [Foreign("TagID")]
        public string TagID { set; get; }
     
    }
}
