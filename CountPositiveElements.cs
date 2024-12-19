public class CountPositiveElements
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Contar Elementos Positivos");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, -2, 3},
            {-4, 5, -6},
            {7, 8, -9}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int count = 0;

        // Contamos los elementos positivos
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    count++;
                }
            }
        }

        // Mostramos el resultado
        Console.WriteLine($"Número de elementos positivos: {count}");
    }
}