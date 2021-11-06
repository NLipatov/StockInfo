using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockInfo.Models
{
    public class Stock
    {
        [Key]
        public string ticket { get; set; }
        [Required]
        public string price { get; set; }
    }
}
