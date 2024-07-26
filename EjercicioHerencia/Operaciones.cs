using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public
        
        
        class Operaciones
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Lado { get; set; }

        public double Altura { get; set; }

        public double AreaDeRectangulo => Largo * Ancho;

        public double PerimetroDeRectangulo => 2 * (Largo + Ancho);

        public double VolumenPrismaRectangukar => Largo * Ancho * Altura;

    }
}
