public class MinesweeperGame
{
    public static void Run()
    {
        // Mensaje de bienvenida al ejercicio
        Console.WriteLine("Ejercicio: Juego del Buscaminas");

        // Inicializamos el tablero de 4x4 con minas (-1) y celdas vacías (0)
        int[,] board = new int[4, 4]
        {
            {0, -1, 0, 0},  // Fila 1: La segunda celda tiene una mina.
            {0, 0, -1, 0},  // Fila 2: La tercera celda tiene una mina.
            {-1, 0, 0, 0},  // Fila 3: La primera celda tiene una mina.
            {0, 0, 0, -1}   // Fila 4: La última celda tiene una mina.
        };

        // Imprimimos el tablero inicial
        Console.WriteLine("Tablero inicial:");
        PrintBoard(board);

        // Actualizamos el tablero, calculando los números de minas adyacentes
        UpdateBoard(board);

        // Imprimimos el tablero actualizado
        Console.WriteLine("Tablero actualizado:");
        PrintBoard(board);

        // Fin del ejercicio
        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    // Método para imprimir el tablero
    static void PrintBoard(int[,] board)
    {
        int rows = board.GetLength(0);  // Número de filas
        int cols = board.GetLength(1);  // Número de columnas

        // Recorremos el tablero e imprimimos cada fila
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(board[i, j] + " ");  // Imprimimos cada celda
            }
            Console.WriteLine();  // Imprimimos una nueva línea después de cada fila
        }
    }

    // Método para actualizar el tablero, calculando las minas adyacentes
    static void UpdateBoard(int[,] board)
    {
        int rows = board.GetLength(0);  // Número de filas
        int cols = board.GetLength(1);  // Número de columnas

        // Recorremos todas las celdas del tablero
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Si la celda está vacía (valor 0), calculamos cuántas minas tiene adyacentes
                if (board[i, j] == 0)
                {
                    board[i, j] = CountAdjacentMines(board, i, j);  // Llamamos a la función que cuenta las minas adyacentes
                }
            }
        }
    }

    // Método para contar cuántas minas están adyacentes a la celda (i, j)
    static int CountAdjacentMines(int[,] board, int row, int col)
    {
        int count = 0;  // Contador de minas adyacentes (incluyendo la celda central)
        int rows = board.GetLength(0);  // Número de filas
        int cols = board.GetLength(1);  // Número de columnas

        // Recorremos las 9 celdas (la celda central + 8 adyacentes)
        for (int i = -1; i <= 1; i++)  // Filas
        {
            for (int j = -1; j <= 1; j++)  // Columnas
            {
                int newRow = row + i;  // Nueva fila (con desplazamiento)
                int newCol = col + j;  // Nueva columna (con desplazamiento)

                // Verificamos que la nueva celda esté dentro de los límites del tablero
                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                {
                    // Si la celda tiene una mina (-1), incrementamos el contador
                    if (board[newRow, newCol] == -1)
                    {
                        count++;
                    }
                }
            }
        }

        // Devolvemos el número total de minas (incluyendo la celda central)
        return count;
    }
}
