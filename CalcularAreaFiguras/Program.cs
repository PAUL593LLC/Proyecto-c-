using System;

namespace CalcularAreaFigurasgeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseFigura, altura, area, opcion; 
            string respuesta = "SI"; // Inicializa la variable respuesta

            do
            {
                Console.Clear(); 
                Console.WriteLine("Elija una figura geométrica:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");

                // Validación de entrada para la opción seleccionada
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 3.");
                    continue; // Reinicia el ciclo
                }

                Console.WriteLine("Ingrese la base o el lado:");
                if (!int.TryParse(Console.ReadLine(), out baseFigura) || baseFigura <= 0)
                {
                    Console.WriteLine("Valor no válido. La base o lado debe ser un número positivo.");
                    continue; // Reinicia el ciclo
                }

                Console.WriteLine("Ingrese la altura o el lado:");
                if (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
                {
                    Console.WriteLine("Valor no válido. La altura o lado debe ser un número positivo.");
                    continue; // Reinicia el ciclo
                }

                switch (opcion)
                {
                    case 1: // Cuadrado
                        area = baseFigura * baseFigura; // REALIZA EL CALCULO DEL AREA DE LA FIGURA
                        Console.WriteLine("El área del cuadrado es: " + area);
                        break;
                    case 2: // Rectángulo
                        area = baseFigura * altura; // REALIZA EL CALCULO DEL AREA DE LA FIGURA
                        Console.WriteLine("El área del rectángulo es: " + area);
                        break;
                    case 3: // Triángulo
                        area = (baseFigura * altura) / 2; // REALIZA EL CALCULO DEL AREA DE LA FIGURA
                        Console.WriteLine("El área del triángulo es: " + area);
                        break;
                }

                Console.WriteLine("¿Desea calcular otra figura? (SI/NO)");
                respuesta = Console.ReadLine().Trim();8

            } while (respuesta.Equals("SI", StringComparison.OrdinalIgnoreCase)); // Compara de forma insensible a mayúsculas y minúsculas
        }
    }
}
