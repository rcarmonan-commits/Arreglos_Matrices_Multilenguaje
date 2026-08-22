"""
Actividad Unidad 1 - Protocolo Colaborativo
Asignatura: Estructuras de datos
Programa: Ingeniería del software
IES: Universidad de Cartagena
Tutor: John Carlos Arrieta Arrieta
Estudiante: Rosary Carmona
"""

def main():
    print("=== DESARROLLO DEL PUNTO 2 DE LA GUIA: MATRICES EN PYTHON ===")
    print("-------------------------------------------------------------")
    
    # ==========================================
    # 1. DECLARACION E INICIALIZACION
    # ==========================================
    # En Python, el concepto matemático de "Matriz" se representa en memoria mediante
    # arreglos bidimensionales, lo que programáticamente se traduce como una "lista
    # que contiene otras listas anidadas".
    print("\n-- 1. Creando e inicializando la matriz 3x3 --")
    matriz = [
        [1, 2, 3], # Índice 0 (Primera Fila)
        [4, 5, 6], # Índice 1 (Segunda Fila)
        [7, 8, 9]  # Índice 2 (Tercera Fila)
    ]
    
    # ==========================================
    # 2. RECORRIDO BIDIMENSIONAL POR FILAS (FORMATO TABLA)
    # ==========================================
    # Para visualizar una matriz, se requieren ciclos anidados (O(N*M)).
    # El primer ciclo extrae cada fila completa, y el ciclo interno extrae las celdas.
    print("\n-- 2. Matriz original mostrada en tabla --")
    for fila in matriz:
        for elemento in fila:
            # Imprime el valor sin saltar de línea para mantener el formato horizontal
            print(f"{elemento}  ", end="") 
        print()  # Salto de línea estructural al terminar de iterar la fila actual
        
    # ==========================================
    # 3. RECORRIDO INVERTIDO: POR COLUMNAS
    # ==========================================
    # El recorrido convencional de memoria es Fila -> Columna.
    # Recorrer Columna -> Fila exige invertir el orden de los ciclos for.
    print("\n-- 3. Recorrido de arriba hacia abajo (Por columnas) --")
    columnas = len(matriz[0]) # Cantidad de columnas (tomando la longitud de la primera fila)
    filas = len(matriz)       # Cantidad de filas
    
    # El ciclo exterior ahora controla la coordenada Y (Columna).
    for c in range(columnas):
        print(f"Columna {c}: ", end="")
        # El ciclo interior controla la coordenada X (Fila), simulando un barrido vertical.
        for f in range(filas):
            print(f"{matriz[f][c]} ", end="")
        print()
        
    # ==========================================
    # 4. ALGORITMO DE SUMATORIA COMPLETA
    # ==========================================
    print("\n-- 4. Sumatoria de todos los elementos --")
    suma = 0 # Variable acumuladora inicializada en 0 para evitar basura en memoria
    
    # Bucle anidado para iterar el 100% de los elementos y acumular su valor
    for f in range(filas):
        for c in range(columnas):
            suma += matriz[f][c] 
            
    print(f"Sumando todos los números, el resultado es: {suma}")
    
    # ==========================================
    # 5. ALGORITMO DE INTERCAMBIO (SWAP) DE FILAS
    # ==========================================
    print("\n-- 5. Intercambio de la fila 0 y la fila 2 --")
    # A diferencia de lenguajes como C o C#, en Python la operación de intercambio
    # de posiciones de memoria se puede realizar nativamente mediante desestructuración (swap múltiple),
    # sin necesidad de declarar una variable temporal explícita para evitar pérdida de datos.
    matriz[0], matriz[-1] = matriz[-1], matriz[0]
    
    print("Matriz resultante tras el intercambio en memoria:")
    for fila in matriz:
        for elemento in fila:
            print(f"{elemento}  ", end="")
        print()

if __name__ == "__main__":
    main()
