using System;

public class DiagonalSum
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Suma de diagonales");

        int diag1 = 0;
        int diag2 = 0;
        int[,] matrizDiag = new int[3, 3]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int n = matrizDiag.GetLength(0); // Obtenemos el tamaño de la matriz

        for (int i = 0; i < n; i++)
        {
            diag1 += matrizDiag[i, i]; // Suma de la diagonal principal
            diag2 += matrizDiag[i, n - 1 - i]; //Suma de la diagonal secundaria
        }
        Console.WriteLine("La suma de la primera diagonal es : " + diag1);
        Console.WriteLine("La suma de la segunda diagonal es : " + diag2);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

