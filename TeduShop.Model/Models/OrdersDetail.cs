using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("OrdersDetail")]
    class OrdersDetail
    {
       [Key]
        [ForeignKey("OrderID")]
        public int OrderID { get; set; }
        [Key]
        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public int Quantily { get; set; }
        public virtual Order Order { get; set; }
        //Status k biết dạng Bit
    }
}
