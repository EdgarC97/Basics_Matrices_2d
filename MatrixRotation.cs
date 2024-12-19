using System;

public class MatrixRotation
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Rotación de matriz 90°");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int n1 = matrix.GetLength(0); // Tamaño de la matriz (n x n)

        // Paso 1: Transponer la matriz (intercambiar matrix[i][j] con matrix[j][i])
        for (int i = 0; i < n1; i++)
        {
            for (int j = i + 1; j < n1; j++) // Solo recorremos la parte superior de la diagonal
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        // Paso 2: Revertir cada fila
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1 / 2; j++) // Revertimos solo hasta la mitad de la fila
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n1 - 1 - j];
                matrix[i, n1 - 1 - j] = temp;
            }
        }

        // Mostrar el resultado
        Console.WriteLine("Matriz rotada:");
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

