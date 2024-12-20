// Este ejercicio te ayuda a practicar el recorrido de matrices en un patrón espiral. 
// Mejora tu habilidad para manejar múltiples punteros y condiciones para navegar por una matriz de manera no lineal.

public class SpiralMatrix
{
    public static void Run()
    {
        // Imprime el título del ejercicio
        Console.WriteLine("Ejercicio: Matriz en Espiral");

        // Definimos una matriz 3x3 con valores de ejemplo.
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Llamamos a la función para obtener los elementos de la matriz en orden espiral
        List<int> spiral = SpiralOrder(matrix);

        // Mostramos el resultado en consola: el recorrido en espiral de la matriz
        Console.WriteLine("Orden espiral: " + string.Join(", ", spiral));

        // Mensaje de finalización
        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    // Función que realiza el recorrido en espiral de la matriz
    static List<int> SpiralOrder(int[,] matrix)
    {
        // Lista para almacenar los resultados del recorrido
        List<int> result = new List<int>();

        // Si la matriz está vacía, devolvemos la lista vacía
        if (matrix.GetLength(0) == 0) return result;

        // Inicializamos los límites de la matriz: arriba, abajo, izquierda, derecha
        int top = 0, bottom = matrix.GetLength(0) - 1;  // Límites en filas
        int left = 0, right = matrix.GetLength(1) - 1;  // Límites en columnas

        // Continuamos recorriendo mientras no hayamos cruzado los límites
        while (top <= bottom && left <= right)
        {
            // Recorremos la fila superior de izquierda a derecha
            for (int j = left; j <= right; j++)
                result.Add(matrix[top, j]);  // Añadimos cada elemento a la lista
            top++;  // Movemos el límite superior hacia abajo

            // Recorremos la columna derecha de arriba a abajo
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i, right]);  // Añadimos cada elemento a la lista
            right--;  // Movemos el límite derecho hacia la izquierda

            // Aseguramos que todavía haya filas por recorrer
            if (top <= bottom)
            {
                // Recorremos la fila inferior de derecha a izquierda
                for (int j = right; j >= left; j--)
                    result.Add(matrix[bottom, j]);  // Añadimos cada elemento a la lista
                bottom--;  // Movemos el límite inferior hacia arriba
            }

            // Aseguramos que todavía haya columnas por recorrer
            if (left <= right)
            {
                // Recorremos la columna izquierda de abajo hacia arriba
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i, left]);  // Añadimos cada elemento a la lista
                left++;  // Movemos el límite izquierdo hacia la derecha
            }
        }

        // Devolvemos la lista con el orden espiral
        return result;
    }
}
