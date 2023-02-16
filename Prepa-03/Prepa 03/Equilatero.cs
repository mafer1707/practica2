﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Equilatero: Triangulo
    {
        public Equilatero(float lado, string color) : base(lado, lado, lado, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triágulo equilatero de Color {GetColor()}, Area {GetArea().ToString("0.##")}, Perimetro {GetPerimetro()}");
        }
    }
}
