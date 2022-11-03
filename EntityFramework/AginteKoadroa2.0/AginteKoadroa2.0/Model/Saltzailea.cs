using AginteKoadroa_PG.Models;
using System.ComponentModel.DataAnnotations;



namespace AginteKoadroa_PG.Models
{
    public partial class Saltzailea
    {
        [Key]
        public string id { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
    }
}
