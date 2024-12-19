// Este ejercicio te ayuda a practicar la manipulación de elementos dentro de las filas de una matriz. Mejora tu comprensión sobre cómo intercambiar elementos y trabajar con índices de matriz de manera eficiente.

public class ReverseMatrixRows
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Invertir Filas de la Matriz");

        // Definimos la matriz
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Invertimos cada fila
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, cols - 1 - j];
                matrix[i, cols - 1 - j] = temp;
            }
        }

        // Mostramos el resultado
        Console.WriteLine("Matriz con filas invertidas:");
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