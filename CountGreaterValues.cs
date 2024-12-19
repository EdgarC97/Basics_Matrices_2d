using System;

public class CountGreaterValues
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Contar valores mayores que un número dado");

        Console.WriteLine("Por favor ingresa un numero para compararlo: ");
        string userInput = Console.ReadLine() ?? "";

        // Intentar convertir la entrada del usuario a un número entero
        int userNumber;
        if (!int.TryParse(userInput, out userNumber))
        {
            Console.WriteLine("Por favor ingresa un número válido.");
            return; // Terminar el programa si la entrada no es válida
        }

        int[,] matrixAllMaxValue = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int count = 0; // Variable para contar los valores mayores que userNumber

        // Recorrer la matriz
        for (int i = 0; i < matrixAllMaxValue.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAllMaxValue.GetLength(1); j++)
            {
                if (matrixAllMaxValue[i, j] > userNumber)
                {
                    count++; // Aumentar el contador si el valor es mayor que userNumber
                }
            }
        }

        // Mostrar el resultado
        Console.WriteLine("Hay " + count + " valores mayores que el número ingresado.");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }
}

