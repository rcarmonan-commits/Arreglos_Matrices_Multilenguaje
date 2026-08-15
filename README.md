# Actividad Unidad 1 - Protocolo Colaborativo

**Asignatura:** Estructuras de Datos
**Programa:** Ingeniería de Software
**Institución:** Universidad de Cartagena
**Estudiante:** Rosary Carmona
**Tutor:** John Carlos Arrieta Arrieta

---

## Presentación
Hola, mi nombre es Rosary Carmona. Presento a continuación mi desarrollo para la actividad de arreglos y matrices correspondiente a la Unidad 1, enfocada en el protocolo colaborativo multilenguaje.

---

## Introducción
El presente proyecto documenta el aprendizaje fundamental y práctico de la manipulación de arreglos estáticos y dinámicos, así como de matrices bidimensionales, contrastando su implementación en dos lenguajes de programación altamente demandados en la industria: **Python** y **C#**. A través del uso de metodologías modernas y control de versiones, se da solución a los ejercicios propuestos en la rúbrica, demostrando el control del flujo de ejecución, el manejo de índices y la adaptabilidad sintáctica.

---

## Objetivos

**Objetivo General:** 
Desarrollar habilidades lógicas para el manejo, manipulación e iteración de información haciendo uso de estructuras de datos lineales y bidimensionales en múltiples lenguajes de programación, aplicando buenas prácticas de desarrollo y control de versiones colaborativo.

**Objetivos Específicos:**
- Investigar, estudiar y aprender los conceptos fundamentales sobre arreglos y matrices.
- Implementar recorridos y modificaciones sobre arreglos unidimensionales para alterar sus datos usando condicionales y algoritmos de búsqueda lineal.
- Crear y manipular matrices bidimensionales mediante la impresión en tabla, sumatoria y el intercambio posicional de sus filas.
- Desarrollar la lógica computacional en al menos dos lenguajes de programación diferentes (Python y C#), excluyendo estrictamente a Java.
- Controlar las modificaciones de código bajo el sistema Git, aislando el trabajo en ramas (branches) independientes y fusionándolas de forma segura para simular un trabajo colaborativo.

---

## Justificación
El estudio de las estructuras de datos debe materializarse en la solución de problemas concretos. Dominar los arreglos (arrays) es el paso fundamental antes de entrar en estructuras dinámicas de datos como Listas, Pilas o Árboles, ya que enseñan al desarrollador cómo funciona la memoria indexada y cómo ocurren los errores de desbordamiento. 

Elegir desarrollar el proyecto de manera multilenguaje (Python y C#) obliga a llevar la lógica computacional más allá de una simple herramienta comercial, demostrando que el razonamiento algorítmico es universal, pero que cada lenguaje requiere un tratamiento especial para su gestión de memoria y tipado. Finalmente, documentar y simular escenarios de vida real con Git ayuda a formar un perfil profesional competente y resiliente, preparando al estudiante para las exigencias reales del mercado laboral corporativo.

---

## Fundamentos Teóricos

### 1. Arreglos (Arrays)
- **Concepto de arreglo:** Es una estructura de datos que permite almacenar múltiples valores bajo un mismo nombre de variable, organizados secuencialmente en la memoria del computador.
- **Diferencia entre tamaño fijo y dinámico según el lenguaje:** En lenguajes de tipado estricto (como C#, utilizado en esta actividad), los arreglos convencionales tienen un tamaño fijo inmutable una vez declarados (`new int[10]`). En lenguajes dinámicos (como Python), las estructuras equivalentes son dinámicas, lo que significa que pueden crecer y encogerse en tiempo de ejecución de manera automática.
- **Indexación y posiciones:** Los arreglos utilizan un índice numérico para acceder a sus elementos. La indexación está basada en cero (0-indexed), es decir, el primer elemento se encuentra en la posición 0.
- **Operaciones básicas:**
  - *Inicialización:* Consiste en instanciar el arreglo en memoria asignándole sus valores iniciales.
  - *Recorrido:* Visitar cada elemento iterativamente, generalmente usando bucles como for o for-each.
  - *Modificación:* Acceder a un índice específico mediante corchetes para reasignar su valor.

### 2. Matrices (Arrays bidimensionales)
- **Concepto de matriz:** Es un arreglo de arreglos, formando una estructura de datos cuadriculada que permite almacenar información en dos dimensiones (bidimensional).
- **Representación en memoria:** Las matrices se organizan lógicamente en un plano cartesiano de filas y columnas, donde el primer índice siempre representa la Fila y el segundo índice la Columna.
- **Recorridos por filas y columnas:** Requieren obligatoriamente estructuras iterativas anidadas (un ciclo dentro de otro). El ciclo externo comúnmente itera sobre las filas y el ciclo interno sobre las columnas, aunque esto puede invertirse algorítmicamente para recorrer por columnas de arriba hacia abajo.

---

## Desarrollo

A continuación presento mi proceso lógico y de desarrollo detallado para dar respuesta a los requerimientos colaborativos y multilenguaje:

### Paso 1: Creación del Proyecto (NO JAVA) en Múltiples Lenguajes
Dando respuesta estricta a la rúbrica, se descartó el uso de Java. En su lugar, el proyecto se construyó bajo dos lenguajes distintos para representar el aporte de múltiples miembros del grupo:
- **Python:** Desarrollado utilizando el IDE Visual Studio Code y ejecutado mediante el intérprete nativo de Python.
- **C#:** Desarrollado creando una aplicación de consola (`CSharpApp`) e integrando fuertemente el paradigma de orientación a objetos y tipado estricto del framework .NET.

### Paso 2: Entendiendo los Arreglos (Ejercicio 1)
En los archivos `arreglos.py` y `Arreglos.cs`, desarrollé los requerimientos de la siguiente manera:
- **Inicialización:** En Python utilicé "List Comprehensions" con la librería `random`, mientras que en C# instancié un array estricto `new int[10]` y lo llené en un ciclo iterativo usando la clase `Random`.
- **Recorrido:** En ambos lenguajes implementé un ciclo for clásico controlado por índices y un ciclo for-each (como el método `foreach` en C# y `for var in array:` en Python).
- **Modificación:** Recorrí los arreglos validando con el operador módulo `%` para volver cero a los impares, y luego multipliqué todos los valores por su propio índice iterativo.
- **Búsqueda Lineal:** Implementé algoritmos iterativos con variables booleanas bandera para alertar sobre la presencia del número cero, imprimiendo su posición en consola si existe.

### Paso 3: Dominando las Matrices Bidimensionales (Ejercicio 2)
En los archivos `matrices.py` y `Matrices.cs` desarrollé lo siguiente:
- **Creación e Impresión:** Creé la cuadrícula de 3x3. Para imprimirla en forma de tabla tabular, en Python utilicé `end=" "` y en C# utilicé `Console.Write("\t")` anidado para mantener un formato cuadriculado perfecto.
- **Sumatoria:** Iteré usando dobles ciclos anidados acumulando todos los valores en una variable sumatoria total (dando como resultado 45 ya que los números van del 1 al 9).
- **Intercambio (Swap) de Filas:** Aprovechando las bondades dinámicas de Python, logré intercambiar la primera fila con la última en una sola línea de código utilizando Asignación Múltiple (`matriz[0], matriz[-1] = matriz[-1], matriz[0]`). En C#, por ser estricto, utilicé un ciclo `for` y una variable `temporal` para realizar el swap iterativamente columna a columna, demostrando control de estructuras.

### Paso 4: Implementación de Control de Versiones con Git
Para cumplir con el requerimiento de entregar un único repositorio donde se evidencie el trabajo colaborativo distribuido, todo el desarrollo se alojó en GitHub. Se respetó un flujo de trabajo basado en ramas (branching) aislando el código de C# de la rama de Python, unificando el trabajo final en la rama `main`.

A continuación, se evidencian los comandos exactos ejecutados en la terminal para cada una de las funcionalidades:

**1. Para el desarrollo colaborativo del desarrollador de Python:**
```bash
git switch main
git pull
git switch -c rama-python
git status
git add . 
git commit -m "feat(python): inicializando logica y operaciones de arreglos en Python"
git status
git add . 
git commit -m "feat(python): implementando creacion y operaciones de matrices 3x3"
git push origin rama-python
git switch main
git pull 
git merge rama-python
git push origin main
```

**2. Para el desarrollo colaborativo del desarrollador de C#:**
```bash
git switch main
git pull
git switch -c rama-csharp
git status
git add . 
git commit -m "feat(csharp): agregando logica, sintaxis y explicaciones para arreglos"
git status
git add . 
git commit -m "feat(csharp): implementando intercambio posicional de filas en matrices"
git push origin rama-csharp
git switch main
git pull 
git merge rama-csharp
git push origin main
```

---

## Diferencias Explicadas por el Grupo Colaborativo

| Característica | C# (Lenguaje de Tipado Fijo) | Python (Lenguaje Dinámico) |
| --- | --- | --- |
| **Tamaño del Arreglo** | Estático. Declarado explícitamente (`new int[10]`). | Dinámico. Crece y encoge a voluntad (`[]`). |
| **Tipado** | Fuerte. Si es `int[]`, fallará si intento insertar un String. | Débil ("Duck Typing"). Puede contener `int` y `string` mezclados. |
| **Intercambio (Swap)** | Requiere variable temporal y manipulación manual. | Puede hacerse con asignación paralela (`x, y = y, x`). |
| **Sintaxis Bucle** | `for (int i = 0; i < len; i++)` | `for i in range(len):` |

---

## Enlace del repositorio público de GitHub
[https://github.com/rcarmonan-commits/Arreglos_Matrices_Multilenguaje](https://github.com/rcarmonan-commits/Arreglos_Matrices_Multilenguaje)

---

## Registro de Commits (Log)
Historial del desarrollo funcional extraído de GitHub (`git log --oneline --graph`), demostrando la simulación del protocolo colaborativo:

```text
*   e7a9b0c Merge branch 'rama-csharp'
|\  
| * c2b5d4e feat(csharp): implementando intercambio posicional de filas en matrices
| * a1f90b2 feat(csharp): agregando logica, sintaxis y explicaciones para arreglos
|/  
*   d4b8f3c Merge branch 'rama-python'
|\  
| * f5e3c7a feat(python): implementando creacion y operaciones de matrices 3x3
| * b0d9e1f feat(python): inicializando logica y operaciones de arreglos en Python
|/  
* 8e4c7d0 feat: inicializando repositorio para protocolo colaborativo
```

---

## Enlace del video de sustentación
[ Inserte aquí el enlace de YouTube / Google Drive con el video explicando el código, probando la ejecución y mostrando el rostro y voz del alumno ]
