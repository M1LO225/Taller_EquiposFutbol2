using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_EquiposFutbol2.Models;

namespace Taller_EquiposFutbol2.Data
{
    public class Taller_EquiposFutbol2Context : DbContext
    {
        public Taller_EquiposFutbol2Context (DbContextOptions<Taller_EquiposFutbol2Context> options)
            : base(options)
        {
        }

        public DbSet<Taller_EquiposFutbol2.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller_EquiposFutbol2.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Taller_EquiposFutbol2.Models.Estadio> Estadio { get; set; } = default!;
    }
}
