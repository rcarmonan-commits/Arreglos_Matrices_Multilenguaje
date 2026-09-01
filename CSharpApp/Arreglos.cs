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
    public class Arreglos
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== DESARROLLO DEL PUNTO 1 DE LA GUIA: ARREGLOS EN C# ===");
            Console.WriteLine("---------------------------------------------------------");

            // ==========================================
            // 1. DECLARACIÓN E INICIALIZACIÓN ESTÁTICA
            // ==========================================
            // A diferencia de Python donde los arreglos (listas) son dinámicos y pueden crecer,
            // en C# los arreglos (Arrays) nativos tienen una fuerte tipificación estática.
            // Esto significa que la memoria debe reservarse previamente. Al declarar 'new int[10]',
            // el sistema operativo asigna un bloque contiguo en la memoria RAM exactamente
            // para 10 espacios enteros, y este tamaño ya no podrá ser alterado (inmutable).
            Console.WriteLine("\n-- 1. Declaración e inicialización con aleatorios --");
            int[] arreglo = new int[10]; 
            
            // Instanciamos el objeto Random de .NET para la generación de datos.
            Random random = new Random();

            // Llenamos el arreglo reservado iterando desde el índice 0 hasta el 9.
            for (int i = 0; i < arreglo.Length; i++)
            {
                // El método Next genera un número entero aleatorio comprendido entre 1 y 100.
                arreglo[i] = random.Next(1, 101); 
            }
            Console.WriteLine("Arreglo en memoria RAM llenado exitosamente.");

            // ==========================================
            // 2. RECORRIDO ESTRUCTURAL CON BUCLE FOR
            // ==========================================
            Console.WriteLine("\n-- 2. Recorrido usando un bucle FOR clásico --");
            // El ciclo FOR nos permite un acceso secuencial directo a memoria O(1)
            // iterando el puntero del array apoyado en el indexador [i].
            for (int i = 0; i < arreglo.Length; i++)
            {
                // Usamos interpolación de strings ($) para inyectar las variables directamente.
                Console.WriteLine($"En la posición {i} del arreglo hay un: {arreglo[i]}");
            }

            // ==========================================
            // 3. RECORRIDO FUNCIONAL CON FOR-EACH
            // ==========================================
            // C# implementa la interfaz IEnumerable, lo cual permite usar la instrucción 'foreach'.
            // Esta estructura abstae los índices y evita errores clásicos como el desbordamiento
            // de buffer (IndexOutOfRangeException), enfocándose únicamente en extraer el dato.
            Console.WriteLine("\n-- Recorrido usando un FOR-EACH --");
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // 4. MODIFICACIÓN ESTRUCTURAL DE DATOS
            // ==========================================
            Console.WriteLine("-- 3. Modificando los datos por reglas matemáticas... --");
            // Para modificar el arreglo, es mandatorio utilizar el FOR tradicional, puesto que
            // el ciclo foreach es estrictamente de lectura (read-only) en arreglos.
            for (int i = 0; i < arreglo.Length; i++)
            {
                // Evaluación condicional: comprobamos si el elemento no es par calculando
                // si el residuo de la división entre 2 es diferente de cero.
                if (arreglo[i] % 2 != 0)
                {
                    // Al ser impar, forzamos la sobrescritura del puntero en memoria a 0.
                    arreglo[i] = 0;
                }
                
                // Posterior a la validación, mutamos el valor real multiplicándolo por 
                // su peso posicional (su índice i).
                arreglo[i] = arreglo[i] * i;
            }

            Console.WriteLine("Arreglo después de aplicar las mutaciones:");
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            // ==========================================
            // 5. ALGORITMO BÁSICO DE BÚSQUEDA LINEAL
            // ==========================================
            // Búsqueda secuencial iterativa que revisa celda por celda (O(n)).
            Console.WriteLine("\n-- 4. Búsqueda Lineal del número cero --");
            int numeroBuscado = 0;
            // Usamos un boolean como "bandera" (flag) que nos informará
            // sobre el estado terminal del proceso de búsqueda.
            bool encontrado = false; 

            for (int i = 0; i < arreglo.Length; i++)
            {
                // La operación '==' evalúa la equidad aritmética entre la variable y la celda actual
                if (arreglo[i] == numeroBuscado)
                {
                    Console.WriteLine($"¡Encontré un cero en la posición {i}!");
                    encontrado = true; // Levantamos la bandera para confirmar un "Hit" (acierto)
                }
            }

            // Si al salir del bucle la bandera nunca fue levantada, concluimos la ausencia del dato.
            if (!encontrado)
            {
                Console.WriteLine("No había ceros en el arreglo.");
            }
        }
    }
}
