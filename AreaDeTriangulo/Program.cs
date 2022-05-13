using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDeTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Averiguar el area de un triangulo
            double BASE, ALTURA, RESUL;
            string linea;
            Console.WriteLine("Digite la base: "); linea = Console.ReadLine();
            BASE = double.Parse(linea);

            Console.WriteLine("Digite la altura: "); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;

            Console.WriteLine("El area del triangulo es: " + String.Format("{0:g}", RESUL));
            Console.WriteLine();


        }
    }
}
