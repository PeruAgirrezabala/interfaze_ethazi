using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa_PG.Models
{
    public partial class Bezeroa
    {
        [Key]
        public string id { get; set; }
        public string Izena { get; set; }
        public string Helbidea { get; set; }
        public string Telf { get; set; }
        public string Emaila { get; set; }
        public string SaltzaileaId { get; set; }
        public virtual Saltzailea Saltzailea { get; set; }
        public virtual List<Salmenta> Salmentas { get; set; }
    }
}
