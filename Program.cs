using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesConSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validar la calificación
            //Andy Garzón
            int calificacion;
            do
            {
                Console.Write("Introduce la calificación (0-100): ");
                calificacion = int.Parse(Console.ReadLine());

                switch (calificacion)
                {
                    case int n when (n >= 90 && n <= 100):
                        Console.WriteLine("Tu calificación es: A");
                        break;
                    case int n when (n >= 80 && n <= 89):
                        Console.WriteLine("Tu calificación es:B");
                        break;
                    case int n when (n >= 70 && n <= 79):
                        Console.WriteLine("Tu calificación es:C");
                        break;
                    case int n when (n >= 60 && n <= 69):
                        Console.WriteLine("Tu calificación es:D");
                        break;
                    case int n when (n >= 0 && n <= 59):
                        Console.WriteLine("Tu calificación es:F");
                        break;
                    default:
                        Console.WriteLine("Calificación no válida.");
                        break;
                }
            } while (true); //El Programa se repite
        }
    }
}

