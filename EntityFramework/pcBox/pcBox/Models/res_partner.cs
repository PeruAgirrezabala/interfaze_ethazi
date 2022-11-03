using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcBox.Models
{
    public partial class res_partner
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int company_id { get; set; }
        public DateTime create_date { get; set; }
        public string display_name { get; set; }
        public bool is_active { get; set; }
        public int supplier_rank { get; set; }
        public int customer_rank { get; set; }
        public Boolean is_company { get; set; }
        public virtual List<sale_order> sale_order { get; set; }

    }
}
