/*
 * Actividad Unidad 1 - Protocolo Colaborativo
 * Asignatura: Estructuras de datos
 * Programa: Ingeniería del software
 * IES: Universidad de Cartagena
 * Tutor: John Carlos Arrieta Arrieta
 * Estudiante: Rosary Carmona
 */
using System;

namespace CSharpApp
{
    // Esta es la clase principal Entry-Point del sistema
    // El compilador de C# requiere una clase que posea el método 'static void Main'
    // que es invocado automáticamente por el CLR (Common Language Runtime) al momento de ejecución.
    class Program
    {
        static void Main(string[] args)
        {
            // Impresión del encabezado didáctico en la consola del sistema operativo
            Console.WriteLine("==========================================================");
            Console.WriteLine(" PROTOCOLO COLABORATIVO - UNIDAD 1 (ESTRUCTURAS DE DATOS) ");
            Console.WriteLine("==========================================================\n");

            // Diseño de la interfaz textual (Menú)
            Console.WriteLine("¿Qué desea ejecutar?");
            Console.WriteLine("1. Ejercicio 1: Arreglos (Arrays)");
            Console.WriteLine("2. Ejercicio 2: Matrices (Arrays Bidimensionales)");
            Console.WriteLine("3. Salir");
            Console.Write("\nSeleccione una opción: ");
            
            // Console.ReadLine() pausa la ejecución del hilo principal esperando un 'Enter' del usuario.
            // Retorna un objeto string que aloja los caracteres digitados en la terminal.
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            // Bloque lógico de ramificación de flujo (switch-case).
            // Compara el objeto 'opcion' extraído del buffer contra literales string constantes.
            switch (opcion)
            {
                case "1":
                    // Desvío arquitectónico hacia la clase Arreglos.
                    Arreglos.Ejecutar();
                    break;
                case "2":
                    // Desvío arquitectónico hacia la clase Matrices.
                    Matrices.Ejecutar();
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    // Validación en caso de inyección de datos fuera del rango permitido.
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
