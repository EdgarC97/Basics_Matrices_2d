using System;

public class ReverseMatrixRowsAndColumns
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Invertir Filas y Columnas de la Matriz");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz original:");
        PrintMatrix(matrix);

        // Invertimos las filas
        ReverseRows(matrix);
        Console.WriteLine("Matriz con filas invertidas:");
        PrintMatrix(matrix);

        // Invertimos las columnas
        ReverseColumns(matrix);
        Console.WriteLine("Matriz con columnas invertidas:");
        PrintMatrix(matrix);
    }

    // Método para invertir las filas de la matriz
    public static void ReverseRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++) // Recorremos las filas
        {
            for (int j = 0; j < cols / 2; j++) // Recorremos hasta la mitad de cada fila
            {
                int temp = matrix[i, j]; // Guardamos el elemento actual en una variable temporal.
                matrix[i, j] = matrix[i, cols - 1 - j]; // Asignamos al índice actual el valor de su opuesto.
                matrix[i, cols - 1 - j] = temp; // Asignamos al índice opuesto el valor original del actual.
            }
        }
    }

    // Método para invertir las columnas de la matriz
    public static void ReverseColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++) // Recorremos las columnas
        {
            for (int i = 0; i < rows / 2; i++) // Recorremos hasta la mitad de cada columna
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[rows - 1 - i, j];
                matrix[rows - 1 - i, j] = temp;
            }
        }
    }

    // Método para imprimir la matriz
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
