using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Escaleno: Triangulo
    {
        public Escaleno(float lado1, float lado2, float lado3, string color): base(lado1, lado2, lado3, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triángulo escaleno de Color {GetColor()}, Area {GetArea().ToString("0.##")}, Perimetro {GetPerimetro()}");
        }
    }
}
