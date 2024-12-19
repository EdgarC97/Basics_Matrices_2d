using System;

public class MatrixSum
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Suma de todos los elementos");

        int sum1 = 0;

        int[,] matrizSum = new int[3, 3]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        for (int i = 0; i < matrizSum.GetLength(0); i++)
        {
            for (int j = 0; j < matrizSum.GetLength(1); j++)
            {
                sum1 += matrizSum[i, j];
            }
        }

        Console.WriteLine("La suma de toda la matriz es : " + sum1);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

