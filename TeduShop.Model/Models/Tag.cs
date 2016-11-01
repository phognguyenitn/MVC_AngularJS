﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    class Tag
    {
        [Key]
        [ForeignKey]
        public string ID { get; set;  }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
