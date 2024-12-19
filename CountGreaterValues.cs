using System;

public class CountGreaterValues
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Contar valores mayores que un número dado");

        Console.Write("Por favor ingresa un numero para compararlo: ");
        int userInput = int.Parse(Console.ReadLine() ?? "");

        int[,] matrixAllMaxValue = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int count = 0; // Variable para contar los valores mayores que userInput

        // Recorrer la matriz
        for (int i = 0; i < matrixAllMaxValue.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAllMaxValue.GetLength(1); j++)
            {
                if (matrixAllMaxValue[i, j] > userInput)
                {
                    count++; // Aumentar el contador si el valor es mayor que userNumber
                }
            }
        }
        // Mostrar la matriz
        Console.WriteLine("La matriz es :");
        for (int i = 0; i < matrixAllMaxValue.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAllMaxValue.GetLength(1); j++)
            {
                Console.Write(matrixAllMaxValue[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Mostrar el resultado
        Console.WriteLine("Hay " + count + " valores mayores que el número ingresado.");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

