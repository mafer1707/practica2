using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            //Rectangulo rectangulo = new Rectangulo(2, 3, "blanco");

            Triangulo triangulo = new Triangulo(3, 5, 7, "Amarillo");
            Escaleno escaleno = new Escaleno(6, 7, 8, "Morado");
            Isosceles isosceles = new Isosceles(8, 3, "Gris");
            Equilatero equilatero = new Equilatero(9, "Rosado");

            //Figura figura1 = rectangulo_cuadrado;
            //Figura figura2 = rectangulo;

            //Figura figura3 = new Circulo(2, "negro");

            //figura1.MostrarDatos();

            //figura2.MostrarDatos();

            //figura3.MostrarDatos();

            triangulo.MostrarDatos();
            escaleno.MostrarDatos();
            isosceles.MostrarDatos();
            equilatero.MostrarDatos();

            //Console.WriteLine($" Area {figura3.GetArea().ToString("0.##")}, Perimetro {figura3.GetPerimetro().ToString("0.##")}");

            Console.ReadLine();
           
            
        }
    }
}
