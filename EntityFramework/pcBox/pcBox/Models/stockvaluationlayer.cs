using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcBox.Models
{
    public partial class stockvaluationlayer
    {
        [Key]
        public int id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }

        public int stock_move_id { get; set; }

        public virtual stockmove StockMove { get; set; }
    }
}
