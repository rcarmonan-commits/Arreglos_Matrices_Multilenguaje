"""
Actividad Unidad 1 - Protocolo Colaborativo
Asignatura: Estructuras de datos
Programa: Ingeniería del software
IES: Universidad de Cartagena
Tutor: John Carlos Arrieta Arrieta
Estudiante: Rosary Carmona
"""
import random

def main():
    print("=== DESARROLLO DEL PUNTO 1 DE LA GUIA: ARREGLOS EN PYTHON ===")
    print("-------------------------------------------------------------")
    
    # ==========================================
    # 1. DECLARACION E INICIALIZACION
    # ==========================================
    # En Python, las estructuras equivalentes a los arreglos se denominan "Listas".
    # Su principal ventaja teórica es que son dinámicas en memoria: no requieren que
    # especifiquemos su tamaño fijo al momento de declararlas.
    print("\n-- 1. Declaración e inicialización con aleatorios --")
    
    # Utilizamos "List Comprehension", una característica avanzada de Python que
    # permite iterar y poblar la lista en una sola línea de código, haciendo el
    # código mucho más limpio y eficiente en comparación con un ciclo tradicional.
    # Se llena con números aleatorios entre 1 y 100.
    arreglo = [random.randint(1, 100) for _ in range(10)]
    
    # ==========================================
    # 2. RECORRIDO CON BUCLE FOR CLASICO (POR INDICE)
    # ==========================================
    # A pesar de ser dinámicas, las listas mantienen la indexación tradicional (base 0).
    # Este bucle simula el comportamiento de un "for (int i=0; i<N; i++)" de C#.
    print("\n-- 2. Recorrido usando un bucle FOR clásico --")
    for i in range(len(arreglo)):
        print(f"En la posición {i} del arreglo hay un: {arreglo[i]}")
        
    # ==========================================
    # 3. RECORRIDO CON BUCLE FOR-EACH (POR ELEMENTO)
    # ==========================================
    # El bucle for-each en Python abstrae la complejidad de los índices,
    # extrayendo directamente el valor de la memoria de la lista.
    print("\n-- Recorrido usando un FOR-EACH --")
    for valor in arreglo:
        print(valor, end=" ")
    print("\n")
    
    # ==========================================
    # 4. MODIFICANDO LOS DATOS (Operaciones Lógicas)
    # ==========================================
    print("-- 3. Modificando los datos por reglas matemáticas... --")
    for i in range(len(arreglo)):
        # Condicional lógico: si el módulo (%) de 2 no es 0, es un número impar.
        # En dicho caso, sobreescribimos la posición en memoria con un 0.
        if arreglo[i] % 2 != 0:
            arreglo[i] = 0 
            
        # Operación aritmética: multiplicamos el valor de la celda por su índice numérico 'i'.
        arreglo[i] = arreglo[i] * i
        
    print("Arreglo después de ser modificado:")
    print(arreglo)
    
    # ==========================================
    # 5. ALGORITMO DE BUSQUEDA LINEAL
    # ==========================================
    # Implementamos un algoritmo de búsqueda secuencial O(N).
    # Es el algoritmo más básico para estructuras no ordenadas.
    print("\n-- 4. Búsqueda Lineal del número cero --")
    numero_buscado = 0
    encontrado = False # Bandera (flag) lógica para controlar el estado de la búsqueda
    
    for i in range(len(arreglo)):
        # Evaluamos cada celda secuencialmente
        if arreglo[i] == numero_buscado:
            print(f"¡Encontré un cero en la posición {i}!")
            encontrado = True
            
    # Si la bandera sigue siendo falsa tras finalizar el ciclo, el número no existe.
    if not encontrado:
        print("No había ceros en el arreglo.")

if __name__ == "__main__":
    main()
