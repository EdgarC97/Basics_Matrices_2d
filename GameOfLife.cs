public class GameOfLife
{
    public static void Run()
    {
        //Definimos el tablero
        int[,] board = new int[,]
        {
            {0,1,1,0,1},
            {1,0,1,1,0},
            {0,1,0,1,0},
            {0,1,0,0,0}
        };

        //Imprimimos el tablero
        Console.WriteLine("Tablero inicial:");
        PrintBoard(board);

        // Crear una instancia de la clase Solution y ejecutar el método GameOfLife
        Solution solution = new Solution();
        solution.GameOfLife(board);

        Console.WriteLine("Estado final del tablero:");
        PrintBoard(board);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();

    }

    private static void PrintBoard(int[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        //Recorremos el tablero
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

public class Solution
{
    public void GameOfLife(int[,] board)
    {
        //Obtenemos las dimensiones del tablero
        int numRows = board.GetLength(0);
        int numCols = board.GetLength(1);

        // Recorremos cada celda del tablero
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                // Contamos los vecinos vivos, inicializando en -board[row, col] para evitar contar la celda misma si está viva
                int liveNeighbors = -board[row, col];
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        // Comprobamos si el vecino está dentro de los límites y es vivo
                        if (i >= 0 && i < numRows && j >= 0 && j < numCols && board[i, j] > 0)
                        {
                            liveNeighbors++;
                        }
                    }
                }
                // Aplicamos las reglas del Juego de la Vida para determinar el siguiente estado:
                // Regla 1 o Regla 3: Cualquier celda viva con menos de dos vecinos vivos o con más de tres vecinos vivos muere
                //la marcamos como 2 temporalmente
                if (board[row, col] == 1 && (liveNeighbors < 2 || liveNeighbors > 3))
                {
                    board[row, col] = 2;
                }

                // Regla 4: Cualquier celda muerta con exactamente tres vecinos vivos se convierte en una célula viva
                //la marcamos como -1 temporalmente
                if (board[row, col] == 0 && liveNeighbors == 3)
                {
                    board[row, col] = -1;
                }
            }
        }

        // Volvemos a recorrer el tablero para actualizar los estados temporales a los estados finales
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                // Un valor de 2 significa que la celda estaba viva y ahora está muerta
                if (board[row, col] == 2)
                {
                    board[row, col] = 0;
                }
                // Un valor de -1 significa que la celda estaba muerta y ahora está viva
                if (board[row, col] == -1)
                {
                    board[row, col] = 1;
                }
            }
        }

    }
}