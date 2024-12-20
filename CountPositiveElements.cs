public class CountPositiveElements
{
    public static void Run()
    {
        //Declaramos la matrix
        int[,] matrix = new int[5, 5]
        {
            {1,2,3,4,5},
            {-1,-2,-3,-4,-5},
            {1,2,3,4,5},
            {-1,-2,-3,-4,-5},
            {1,2,3,4,5},
        };

        //Obtenemos el tamaño de la matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        //Contador para positivos
        int countPos = 0;
        //Contador para negativos
        int countNeg = 0;

        //Recorremos la matriz
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                //Si son positivos
                if (matrix[i, j] > 0)
                {
                    countPos++;
                }
                //Si son negativos
                if (matrix[i, j] < 0)
                {
                    countNeg++;
                }
            }
        }

        //Imprimimos la matrix
        Console.WriteLine("La matriz inicial es: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        //Imprimimos los resultados
        Console.WriteLine("Numeros de elementos positivos: " + countPos);
        Console.WriteLine("Numeros de elementos negativos: " + countNeg);

    }
}