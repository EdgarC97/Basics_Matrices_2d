using System;

public class BasicMatrixOperations
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Operaciones básicas de matrices");

        //Matriz bidimensional
        int sum = 0;
        int sumr = 0;

        //Declaracion de matriz con relleno de forma manual
        int[,] matrix1 =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };

        //Declaracion de matriz para relleno con numeros random
        int[,] matrix1r = new int[3, 3];

        //Relleno de matriz con numeros random
        Random randomNumber = new Random();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix1r[i, j] = randomNumber.Next(1, 100);
            }
        }

        //Recorrido de la matriz bidimensional con numeros quemados 
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
        Console.WriteLine();

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
        Console.WriteLine();

        Console.WriteLine("La posicion de la matriz es: " + matrix1[2, 0]);
        Console.WriteLine("La posicion de la matriz random es: " + matrix1r[1, 1]);
        Console.WriteLine();

        //Arreglo de arreglos
        int[][] matrix2 =
        {
            new int [] {1,2,3,4,5},
            new int [] {7,1,4},
            new int [] {1,2},
        };

        for (int i = 0; i < matrix2.Length; i++)
        {
            for (int j = 0; j < matrix2[i].Length; j++)
            {
                Console.Write(matrix2[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

