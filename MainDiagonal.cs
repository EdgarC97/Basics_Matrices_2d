//Este ejercicio te ayuda a entender cómo acceder a elementos específicos de una matriz basándose en sus índices. Practicas la extracción de la diagonal principal, lo cual es útil en varios algoritmos y aplicaciones matemáticas.

public class MainDiagonal
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Diagonal Principal");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int n = matrix.GetLength(0);
        int[] diagonal = new int[n];

        // Extraemos la diagonal principal
        for (int i = 0; i < n; i++)
        {
            diagonal[i] = matrix[i, i];
        }

        // Mostramos el resultado
        Console.WriteLine("Diagonal principal:");
        Console.WriteLine(string.Join(" ", diagonal));
    }
}