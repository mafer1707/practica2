using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Isosceles : Triangulo
    {
        public Isosceles(float lado_igual, float lado2, string color) : base(lado_igual, lado_igual, lado2, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triángulo isósceles de Color {GetColor()}, Area {GetArea().ToString("0.##")}, Perimetro {GetPerimetro()}");
        }
    }
}
