using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller_EquiposFutbol2.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        [ForeignKey("IdEquipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

    }
}
