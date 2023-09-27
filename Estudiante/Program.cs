using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        { //Estudiante
            Console.WriteLine("Cálculo del promedio final del estudiante");
            Console.Write("Ingrese el carnet del estudiante: ");
            string carnet = Console.ReadLine();
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            // Pedir las calificaciones de quices, tareas y exámenes jj
            Console.Write("Ingrese la calificación del Quiz 1: ");
            double quiz1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del Quiz 2: ");
            double quiz2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del Quiz 3: ");
            double quiz3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación de la Tarea 1: ");
            double tarea1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación de la Tarea 2: ");
            double tarea2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación de la Tarea 3: ");
            double tarea3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Examen 1: ");
            double examen1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del Examen 2: ");
            double examen2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del Examen 3: ");
            double examen3 = double.Parse(Console.ReadLine());

            // Calcular porcentajes
            double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 3) * 0.25;
            double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 3) * 0.30;
            double porcentajeExamenes = ((examen1 + examen2 + examen3) / 3) * 0.45;

            // Calcular promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinar la condición del estudiante
            string condicion;

            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar resultados
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices}%");
            Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas}%");
            Console.WriteLine($"Porcentaje de Exámenes: {porcentajeExamenes}%");
            Console.WriteLine($"Promedio Final: {promedioFinal}");
            Console.WriteLine($"Condición del estudiante: {condicion}");

            Console.ReadLine();
        }
    }
}
