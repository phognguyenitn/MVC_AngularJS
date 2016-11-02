﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public  class ProductTag
    {
        [Key]     
        public int ProductID { set; get; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }
       
        [Foreign("ProductID")]
        public virtual Product Product { set; get; }
        [Foreign("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
