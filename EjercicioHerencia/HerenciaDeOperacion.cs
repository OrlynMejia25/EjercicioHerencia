using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class HerenciaDeOperacion : Operaciones
    {
        public void Imprimir()
        {
            Console.WriteLine($"Área del rectángulo (Largo: {Largo},por Ancho: {Ancho}) es igual a: {AreaDeRectangulo}");
            Console.WriteLine($"Perímetro del rectángulo (Largo: {Largo}, por  Ancho: {Ancho}) es igual a: {PerimetroDeRectangulo}");
            Console.WriteLine($"Volumen del cubo (Largo: {Largo},por Ancho, {Ancho}, por Altura, {Altura}) es igual a: {VolumenPrismaRectangukar}");
        }


    }
}
