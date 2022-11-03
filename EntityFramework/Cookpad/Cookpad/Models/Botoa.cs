using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookpad.Models
{
    public partial class Botoa
    {

       
        [Key]
        public int Id { get; set; }
        public String ErabiltzaileaId { get; set; }
        public int ErrezetaId { get; set; }

        public String Urtea { get; set; }
        public String Komentarioa { get; set; }


        public virtual Erabiltzailea Erabiltzailea { get; set; }
        public virtual List<Erabiltzailea> erabiltzaileak { get; set; }
        public virtual List<Errezeta> Errezetak { get; set; }
        public virtual Errezeta Errezeta { get; set; }
    }
}
