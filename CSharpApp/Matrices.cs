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
    public class Matrices
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== DESARROLLO DEL PUNTO 2 DE LA GUIA: MATRICES EN C# ===");
            Console.WriteLine("---------------------------------------------------------");

            // ==========================================
            // 1. DECLARACIÓN E INICIALIZACIÓN DE MATRICES
            // ==========================================
            Console.WriteLine("\n-- 1. Declaración e inicialización manual --");
            // En C# existen dos conceptos distintos para estructuras multidimensionales:
            // 1) Arreglos dentados o Jagged Arrays (int[][]): Matrices donde las filas pueden tener distintas longitudes.
            // 2) Matrices multidimensionales verdaderas (int[,]): Memoria estrictamente rectangular y compacta.
            // Aquí utilizaremos la verdadera matriz multidimensional [,] definiendo un bloque de 3x3 en memoria.
            int[,] matriz = new int[3, 3];
            int contador = 1;

            // Almacenamiento secuencial iterando coordenadas cartesianas X (filas) y Y (columnas).
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    matriz[fila, col] = contador;
                    contador++; // Llenamos las casillas numéricamente de 1 hasta 9
                }
            }
            Console.WriteLine("Matriz multidimensional [,] de 3x3 inicializada exitosamente.");

            // ==========================================
            // 2. RECORRIDO ORTOGONAL EN FORMA DE TABLA
            // ==========================================
            // El ciclo clásico para leer matrices opera por filas y columnas anidadas,
            // garantizando una lectura "Horizontal -> Salto -> Horizontal".
            Console.WriteLine("\n-- 2. Recorrido clásico por Filas (Forma de Tabla) --");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // Console.Write imprime en la misma línea y \t agrega un 'tab' separador
                    Console.Write(matriz[fila, col] + "\t");
                }
                // Tras completar una iteración completa sobre las columnas, forzamos el salto
                Console.WriteLine(); 
            }

            // ==========================================
            // 3. RECORRIDO INVERTIDO: POR COLUMNAS
            // ==========================================
            // Desafiamos el ordenamiento estructural base invirtiendo los ejes del bucle for.
            Console.WriteLine("\n-- Recorrido por Columnas (De arriba hacia abajo) --");
            // Obsérvese que 'col' se ha puesto como iterador externo y 'fila' como interno.
            // Esto congela el índice de la columna, forzando a recorrer todas sus celdas
            // de arriba a abajo antes de saltar a la columna adyacente.
            for (int col = 0; col < 3; col++)
            {
                Console.WriteLine($"\nColumna {col}:");
                for (int fila = 0; fila < 3; fila++)
                {
                    Console.WriteLine(matriz[fila, col]);
                }
            }

            // ==========================================
            // 4. OPERACIÓN MATEMÁTICA: SUMATORIA GLOBAL
            // ==========================================
            Console.WriteLine("\n-- 3. Sumar todos los elementos --");
            // Se requiere un acumulador externo para no perder el rastro de la suma
            int suma = 0;
            
            // Un doble for nos garantiza complejidad computacional temporal cuadrática O(n*m)
            // tocando exactamente el 100% de la información dentro del array bidimensional.
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    suma += matriz[fila, col]; // Operador de adición acumulativa
                }
            }
            Console.WriteLine($"La sumatoria total de los elementos de la matriz es: {suma}");

            // ==========================================
            // 5. OPERACIÓN AVANZADA: INTERCAMBIO DE FILAS (SWAP)
            // ==========================================
            Console.WriteLine("\n-- 4. Intercambiar la primera fila con la última --");
            // PRECAUCIÓN: A diferencia de lenguajes de tipado dinámico como Python donde `a, b = b, a` es válido,
            // en C# el intercambio de direcciones de memoria requiere el diseño de un algoritmo SWAP temporal 
            // clásico para evitar la destrucción accidental de los datos en tránsito.
            
            // Iteramos sobre las 3 columnas y ejecutamos un pivoteo matemático.
            for (int col = 0; col < 3; col++)
            {
                // PASO A: Protegemos el valor de la celda de la Fila 0 alojándolo en RAM temporal (variable caché).
                int temporal = matriz[0, col];
                
                // PASO B: Teniendo el valor a salvo, sobreescribimos la celda de la Fila 0 con la data de la Fila 2.
                matriz[0, col] = matriz[2, col];
                
                // PASO C: Depositamos nuestro dato protegido original en la vacante que dejó la Fila 2.
                matriz[2, col] = temporal;
            }

            Console.WriteLine("¡Fila 0 y Fila 2 intercambiadas con éxito tras aplicar SWAP temporal!\n");
            
            // Imprimir la matriz alterada estructuralmente para verificar
            Console.WriteLine("Matriz Resultante:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matriz[fila, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
