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