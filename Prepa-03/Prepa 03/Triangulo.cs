using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo : Figura
    {
        private float _lado1;
        private float _lado2;
        private float _lado3;

        public Triangulo(float lado1, float lado2, float lado3, string color) : base(color)
        {
            _lado1 = lado1; 
            _lado2 = lado2; 
            _lado3 = lado3; 
        }
        public override double GetArea()
        {
            double semiperimetro = GetPerimetro()/ 2;
            return Math.Sqrt(semiperimetro*(semiperimetro - _lado1)*(semiperimetro - _lado2)*(semiperimetro - _lado3));
        }
        public override double GetPerimetro()
        {
            return _lado1+_lado2+_lado3;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Tiángulo de Color {GetColor()}, Area {GetArea().ToString("0.##")}, Perimetro {GetPerimetro()}");
        }
    }
}