using System;

public class MaxMatrixValue
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Máximo valor de una matriz 2D");

        int [,] matrixMaxValue = new int [4,4]
        {
            {1,2,3,20},
            {4,5,6,7},
            {8,9,10,11},
            {70,18,10,15}
        };
        int maxValue = matrixMaxValue[0, 0]; // Inicializar con el primer valor de la matriz

        for (int i = 0; i < matrixMaxValue.GetLength(0); i++) // Recorriendo las filas
        {
            for (int j = 0; j < matrixMaxValue.GetLength(1); j++) // Recorriendo las columnas
            {
                // Comparar cada elemento con el valor máximo actual
                if (matrixMaxValue[i, j] > maxValue)
                {
                    maxValue = matrixMaxValue[i, j]; // Actualizar el valor máximo
                }
            }
        }

        Console.WriteLine("El valor más alto de toda la matriz es: " + maxValue);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

