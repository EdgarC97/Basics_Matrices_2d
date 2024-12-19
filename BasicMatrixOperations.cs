using System;

public class BasicMatrixOperations
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Operaciones básicas de matrices bidimensionales");

        // ***************** Matriz bidimensional **************************

        //Declaracion de matriz con relleno de forma manual
        int[,] matrix1 =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };

        //Variables para sumas
        int sum = 0;
        int sumr = 0;

        //Recorrido de la matriz bidimensional con numeros quemados 
        Console.WriteLine("\nContenido de la matriz con numeros quemados:");
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(matrix1[i, j] + " ");
                sum += matrix1[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("La suma de todos los numeros es: " + sum);
        Console.WriteLine("El promedio de todos los numeros es: " + sum / 9);
        Console.WriteLine("La posicion de la matriz es: " + matrix1[2, 0]);


        //Declaracion de matriz para relleno con numeros random
        int[,] matrix1r = new int[3, 3];

        //Relleno de matriz con numeros random
        Random randomNumber = new Random();

        Console.WriteLine("\nContenido de la matriz con numeros ramdom:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix1r[i, j] = randomNumber.Next(1, 100);
            }
        }

        //Recorrido de la matriz bidimensional con numeros random 
        for (int i = 0; i < matrix1r.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1r.GetLength(1); j++)
            {
                Console.Write(matrix1r[i, j] + " ");
                sumr += matrix1r[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("La suma de todos los numeros random es: " + sumr);
        Console.WriteLine("El promedio de todos los numeros random es: " + sumr / 9);
        Console.WriteLine("La posicion de la matriz random es: " + matrix1r[1, 1]);
        Console.WriteLine();

        //Operaciones adicionales para matrices bidimensionales

        // Operación 1: Encuentra el valor máximo y mínimo
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i < matrix1r.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1r.GetLength(1); j++)
            {
                if (matrix1r[i, j] > max) max = matrix1r[i, j];
                if (matrix1r[i, j] < min) min = matrix1r[i, j];
            }
        }
        Console.WriteLine($"El valor ramdom máximo es: {max}");
        Console.WriteLine($"El valor ramdom mínimo es: {min}\n");

        // Operación 2: Transponer la matriz
        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < matrix1r.GetLength(1); i++)
        {
            for (int j = 0; j < matrix1r.GetLength(0); j++)
            {
                Console.Write(matrix1r[j, i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Operación 3: Multiplicación escalar
        Console.Write("Ingrese un valor escalar para multiplicar la matriz: ");
        int escalar = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine("Matriz después de la multiplicación escalar:");
        for (int i = 0; i < matrix1r.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1r.GetLength(1); j++)
            {
                Console.Write(matrix1r[i, j] * escalar + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine(" ************Ejercicio de matrices bidimensionales completado. ***************");
        Console.WriteLine();

        //********************* Jagged arrays*******************************
        Console.WriteLine("Ejercicio: Operaciones básicas de jagged arrays");

        //1. Jagged array con tamaños y números aleatorios

        // Solicitar número de filas
        Console.Write("Por favor ingrese el número de filas: ");
        int row = int.Parse(Console.ReadLine() ?? "3");

        // Crear jagged array
        int[][] jagged1 = new int[row][];

        // Inicializar filas con números aleatorios
        Random randomNum = new Random();

        for (int i = 0; i < row; i++)
        {
            Console.Write($"Por favor ingrese el número de columnas para la fila {i + 1}: ");
            int column = int.Parse(Console.ReadLine() ?? "0");
            jagged1[i] = new int[column];

            for (int j = 0; j < column; j++)
            {
                jagged1[i][j] = randomNum.Next(1, 100); // Números aleatorios entre 1 y 100
            }
        }

        // Imprimir el contenido del jagged array
        Console.WriteLine("\nContenido del jagged array con números aleatorios:");
        for (int i = 0; i < jagged1.Length; i++)
        {
            Console.Write($"Fila {i + 1}: "); // Indicar en qué fila estamos
            for (int j = 0; j < jagged1[i].Length; j++)
            {
                Console.Write(jagged1[i][j] + " ");
            }
            Console.WriteLine(); 
        }

        Console.WriteLine("\nEjercicio 1 de jagged arrays completado.");

        //2. Jagged array con tamaños predefinidos y valores del usuario

        // Definir jagged array con tamaños predefinidos
        int[][] jagged2 = new int[3][];

        jagged2[0] = new int[3];
        jagged2[1] = new int[5];
        jagged2[2] = new int[7];

        // Explicamos al usuario cuántas filas y columnas tiene la matriz
        Console.WriteLine("\nEl jagged array tiene la siguiente estructura:");
        Console.WriteLine("Fila 1: 2 columnas");
        Console.WriteLine("Fila 2: 3 columnas");
        Console.WriteLine("Fila 3: 1 columna\n");

        // Solicitar valores para cada posición
        Console.WriteLine("Por favor ingrese los valores de cada posicion");
        for (int i = 0; i < jagged2.Length; i++)
        {
            for (int j = 0; j < jagged2.Length; j++)
            {
                Console.Write($"Ingrese el valor para jagged2 [Fila {i + 1}][Columna {j + 1}]: ");
                jagged2[i][j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        // Imprimir el contenido del jagged array
        Console.WriteLine("\nContenido del jagged array con valores ingresados:");
        for (int i = 0; i < jagged2.Length; i++)
        {
            Console.Write($"Fila {i + 1}: ");
            for (int j = 0; j < jagged2.Length; j++)
            {
                Console.Write(jagged2[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nEjercicio 2 de jagged arrays completado.");

    }
}

