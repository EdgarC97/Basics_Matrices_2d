using System;

public class DiagonalSum
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Suma de diagonales en matrices 3x3");

        // Declaramos la matriz con valores por defecto
        int[,] matrizDiag = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Declaramos la matriz para rellenarla con valores aleatorios
        int[,] matrixRam = new int[3, 3];
        Random random = new Random();
        int n = matrixRam.GetLength(0); // Tamaño de las matrices

        // Rellenamos la matriz aleatoria con valores aleatorios
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixRam[i, j] = random.Next(1, 100);
            }
        }

        // Función para calcular la suma de diagonales
        (int principal, int secundaria) CalcularDiagonales(int[,] matriz)
        {
            int diagonalPrincipal = 0;
            int diagonalSecundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                diagonalPrincipal += matriz[i, i];
                diagonalSecundaria += matriz[i, matriz.GetLength(1) - 1 - i];
            }

            return (diagonalPrincipal, diagonalSecundaria);
        }

        // Calculamos las diagonales de ambas matrices
        var (diag1, diag2) = CalcularDiagonales(matrizDiag);
        var (diag3, diag4) = CalcularDiagonales(matrixRam);

        // Imprimimos las matrices
        Console.WriteLine("\nMatriz con valores por defecto:");
        ImprimirMatriz(matrizDiag);

        Console.WriteLine("\nMatriz con valores aleatorios:");
        ImprimirMatriz(matrixRam);

        // Mostramos los resultados
        Console.WriteLine($"\nSuma de la diagonal principal (matriz por defecto): {diag1}");
        Console.WriteLine($"Suma de la diagonal secundaria (matriz por defecto): {diag2}");
        Console.WriteLine($"Suma de la diagonal principal (matriz aleatoria): {diag3}");
        Console.WriteLine($"Suma de la diagonal secundaria (matriz aleatoria): {diag4}");

        Console.WriteLine("\nEjercicio completado.");
    }

    // Método para imprimir matrices
    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
