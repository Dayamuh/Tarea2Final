using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camisas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tienda Camisas
            Console.WriteLine("Bienvenido a la tienda de camisas");

            Console.WriteLine("Digite la cantidad de camisas que desea comprar:");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio de una camisa:");
            float precioCamisa = float.Parse(Console.ReadLine());

            float costoTotal = 0;

            if (cantidadCamisas == 1)
            {
                costoTotal = cantidadCamisas * precioCamisa;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                costoTotal = cantidadCamisas * precioCamisa * 0.15f; // Descuento del 15%
            }
            else if (cantidadCamisas > 5)
            {
                costoTotal = cantidadCamisas * precioCamisa * 0.20f; // Descuento del 20%
            }

            Console.WriteLine($"El costo total de {cantidadCamisas} camisas es: {costoTotal}");

            Console.WriteLine("Gracias por su compra");

            Console.ReadLine();
        }
    }
}
