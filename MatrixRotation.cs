using System;

public class MatrixRotation
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Rotación de matriz 90° y 180°");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Mostrar la matriz inicial
        Console.WriteLine("Matriz Inicial:");
        PrintMatrix(matrix);

        // Crear una copia para la rotación de 90°
        int[,] matrix90 = (int[,])matrix.Clone();
        Rotate90(matrix90);
        Console.WriteLine("Matriz rotada 90°:");
        PrintMatrix(matrix90);

        // Crear otra copia para la rotación de 180°
        int[,] matrix180 = (int[,])matrix.Clone();
        Rotate180(matrix180);
        Console.WriteLine("Matriz rotada 180°:");
        PrintMatrix(matrix180);

        Console.WriteLine("Ejercicio completado.");
    }

    // Método para rotar 90°
    private static void Rotate90(int[,] matrix)
    {
        int n1 = matrix.GetLength(0);

        // Paso 1: Transponer la matriz
        for (int i = 0; i < n1; i++)
        {
            for (int j = i + 1; j < n1; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        // Paso 2: Revertir cada fila
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1 / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n1 - 1 - j];
                matrix[i, n1 - 1 - j] = temp;
            }
        }
    }

    // Método para rotar 180°
    private static void Rotate180(int[,] matrix)
    {
        int n1 = matrix.GetLength(0);

        // Intercambiar elementos opuestos
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                int oppositeRow = n1 - 1 - i;
                int oppositeCol = n1 - 1 - j;

                // Evitar re-intercambiar
                if (i < oppositeRow || (i == oppositeRow && j < oppositeCol))
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[oppositeRow, oppositeCol];
                    matrix[oppositeRow, oppositeCol] = temp;
                }
            }
        }
    }

    // Método para imprimir una matriz
    private static void PrintMatrix(int[,] matrix)
    {
        int n1 = matrix.GetLength(0);
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
