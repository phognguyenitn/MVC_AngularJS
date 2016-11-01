using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int ID { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set;}
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string  PaymentMethod { get; set; }
        public string PamentStatus { get; set; }
        public string Status { get; set;}
         
    }
}
