﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("OrdersDetail")]
    public class OrdersDetail
    {
        [Key]
        [Column(Order=1)]
        public int OrderID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }
        public int Quantily { get; set; }
        [ForeignKey("OrderID")]
        public virtual  Order Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
     
    }
}
