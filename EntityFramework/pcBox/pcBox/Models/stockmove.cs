using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcBox.Models
{
    public partial class stockmove
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int product_id { get; set; }

        public virtual List<stockvaluationlayer> StockValuationLayers { get; set; }

    }
}
