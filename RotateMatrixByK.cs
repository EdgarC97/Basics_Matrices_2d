//Este ejercicio te ayuda a practicar la rotación de matrices 2D. Mejora tu comprensión de cómo manipular índices para realizar transformaciones geométricas en estructuras de datos bidimensionales.
public class RotateMatrixByK
{
    public static void Run()
    {
        // Mensaje inicial que indica que comienza el ejercicio de rotación de la matriz
        Console.WriteLine("Ejercicio: Rotación de Matriz por K posiciones");

        // Definimos una matriz 3x3 con algunos números de ejemplo
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},  // Fila 1
            {4, 5, 6},  // Fila 2
            {7, 8, 9}   // Fila 3
        };

        // Imprimimos la matriz original
        Console.WriteLine("Matriz original:");
        PrintMatrix(matrix);

        // Llamamos a la función que rota la matriz 90 grados por 1 posición
        RotateMatrix(matrix, 1);

        // Imprimimos la matriz después de la rotación
        Console.WriteLine("\nMatriz rotada 90 grados:");
        PrintMatrix(matrix);

        // Fin del ejercicio
        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    // Método para rotar la matriz 90 grados k veces
    static void RotateMatrix(int[,] matrix, int k)
    {
        int n = matrix.GetLength(0);  // Obtenemos el tamaño de la matriz (n x n)
        
        // Aseguramos que el número de rotaciones no sea más de 4
        // Ya que después de 4 rotaciones de 90 grados, la matriz vuelve a su posición original
        k = k % 4; 

        // Realizamos la rotación k veces
        for (int rotation = 0; rotation < k; rotation++)
        {
            // Recorrimos las capas de la matriz (desde la capa exterior hasta la capa interior)
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;  // Primer índice de la capa
                int last = n - 1 - layer;  // Último índice de la capa

                // Realizamos la rotación de las celdas dentro de la capa
                for (int i = first; i < last; i++)
                {
                    // Calculamos el desplazamiento respecto al primer índice de la capa
                    int offset = i - first;

                    // Guardamos temporalmente el valor de la celda superior
                    int top = matrix[first, i];

                    // Realizamos la rotación de las celdas en sentido horario
                    matrix[first, i] = matrix[last - offset, first];  // Célula izquierda a arriba
                    matrix[last - offset, first] = matrix[last, last - offset];  // Célula inferior a izquierda
                    matrix[last, last - offset] = matrix[i, last];  // Célula derecha a inferior
                    matrix[i, last] = top;  // Célula superior a derecha
                }
            }
        }
    }

    // Método para imprimir la matriz de manera legible
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);  // Obtenemos el tamaño de la matriz
        // Recorremos cada fila
        for (int i = 0; i < n; i++)
        {
            // Recorremos cada columna dentro de la fila
            for (int j = 0; j < n; j++)
            {
                // Imprimimos el valor de la celda con un espacio entre cada número
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();  // Imprimimos un salto de línea después de cada fila
        }
    }
}
