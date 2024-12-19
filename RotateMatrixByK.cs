//Este ejercicio te ayuda a practicar la rotación de matrices 2D. Mejora tu comprensión de cómo manipular índices para realizar transformaciones geométricas en estructuras de datos bidimensionales.
public class RotateMatrixByK
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Rotación de Matriz por K posiciones");

        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz original:");
        PrintMatrix(matrix);

        RotateMatrix(matrix, 1);

        Console.WriteLine("\nMatriz rotada 90 grados:");
        PrintMatrix(matrix);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static void RotateMatrix(int[,] matrix, int k)
    {
        int n = matrix.GetLength(0);
        k = k % 4;

        for (int rotation = 0; rotation < k; rotation++)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first, i];

                    matrix[first, i] = matrix[last - offset, first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = top;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

