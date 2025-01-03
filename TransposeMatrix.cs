//Este ejercicio te ayuda a comprender cómo intercambiar elementos en una matriz para cambiar su estructura. La transposición de matrices es una operación fundamental en álgebra lineal y tiene aplicaciones en procesamiento de imágenes y otras áreas.


public class TransposeMatrix
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Matriz Transpuesta");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Mostramos la matriz original
        Console.WriteLine("Matriz original:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Transponemos la matriz
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        // Mostramos el resultado
        Console.WriteLine("Matriz transpuesta:");
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
