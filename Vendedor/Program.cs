using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vendedor
            Console.WriteLine("Bienvenido a la tienda de artículos");

            Console.WriteLine("Digite la cantidad de artículos que desea comprar:");
            int cantidadArticulos = int.Parse(Console.ReadLine());

            int precioPorArticulo;

            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20;
            }
            else
            {
                precioPorArticulo = 15;
            }

            int costoTotal = cantidadArticulos * precioPorArticulo;

            Console.WriteLine($"El precio por artículo es: ${precioPorArticulo}");
            Console.WriteLine($"El costo total de {cantidadArticulos} artículos es: ${costoTotal}");

            Console.WriteLine("Gracias por su compra");

            Console.ReadLine();

        }
    }
}
