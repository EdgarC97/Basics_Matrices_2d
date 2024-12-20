public class SumBorderElements
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Suma de Bordes de la Matriz");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int sum = 0;

        // Sumamos los elementos de los bordes
        Console.WriteLine("La matriz es: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
                if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine();
        }

        // Mostramos el resultado
        Console.WriteLine($"La suma de los bordes es: {sum}");
    }
}
