using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcBox.Models
{
    public partial class saleorderline
    {
        public string name { get; set; }
        public int product_uom_qty { get; set; }
        [Key]
        public int id { get; set; }
    }
}
