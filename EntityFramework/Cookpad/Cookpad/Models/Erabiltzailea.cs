using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookpad.Models
{
    public partial class Erabiltzailea
    {

        [Key]
        public int Id { get; set; }
        public String Izena { get; set; }
        public String Emaila { get; set; }
        public String Ezizena { get; set; }

    }
}
