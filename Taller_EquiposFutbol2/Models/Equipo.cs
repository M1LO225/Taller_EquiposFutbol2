using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_EquiposFutbol2.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string Ciudad { get; set; }
        public string TitulosEquipo { get; set; }
        public bool AdmiteExtranjeros { get; set; }
        [ForeignKey("IdEstadio")]
        public int IdEstadio { get; set; }
        public Estadio Estadio { get; set; }
    }
}
