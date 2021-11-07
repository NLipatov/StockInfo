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
        public string Ticket { get; set; }
        [Required]
        public string Currency { get; set; }
        public string Price { get; set; }
        public string CompanyName { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
