//Este ejercicio te ayuda a practicar el recorrido de matrices en un patrón espiral. Mejora tu habilidad para manejar múltiples punteros y condiciones para navegar por una matriz de manera no lineal.
public class SpiralMatrix
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Matriz en Espiral");

        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> spiral = SpiralOrder(matrix);
        Console.WriteLine("Orden espiral: " + string.Join(", ", spiral));

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();
        if (matrix.GetLength(0) == 0) return result;

        int top = 0, bottom = matrix.GetLength(0) - 1;
        int left = 0, right = matrix.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
                result.Add(matrix[top, j]);
            top++;

            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i, right]);
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    result.Add(matrix[bottom, j]);
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i, left]);
                left++;
            }
        }

        return result;
    }
}

