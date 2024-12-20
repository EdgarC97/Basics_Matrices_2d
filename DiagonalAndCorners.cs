using System;

public class DiagonalAndCorners
{
    public static void Run()
    {
        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int n = matrix.GetLength(0); // Número de filas (también es el número de columnas)
        int sum = 0;
        int sumEsq = 0;

        // Sumamos los elementos de la diagonal principal
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i]; // Los elementos de la diagonal principal tienen índices [i, i]
        }
        // Sumamos los elementos de las esquinas
        sumEsq += matrix[0, 0]; // Esquina superior izquierda
        sumEsq += matrix[0, n - 1]; // Esquina superior derecha
        sumEsq += matrix[n - 1, 0]; // Esquina inferior izquierda
        sumEsq += matrix[n - 1, n - 1]; // Esquina inferior derecha

        //Imprimimos la matriz
        Console.WriteLine("La matriz es: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        // Mostramos la suma de la diagonal
        Console.WriteLine($"Suma de la diagonal principal: {sum}");
        Console.WriteLine($"Suma de las esquinas: {sumEsq}");
    }
}
