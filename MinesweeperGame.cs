//Este ejercicio te ayuda a practicar la implementación de la lógica del juego Buscaminas. Mejora tu habilidad para contar elementos adyacentes en una matriz 2D y actualizar valores basados en las condiciones de las celdas vecinas.
public class MinesweeperGame
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Juego del Buscaminas");

        int[,] board = new int[4, 4]
        {
            {0, -1, 0, 0},
            {0, 0, -1, 0},
            {-1, 0, 0, 0},
            {0, 0, 0, -1}
        };

        UpdateBoard(board);

        Console.WriteLine("Tablero actualizado:");
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static void UpdateBoard(int[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i, j] == 0)
                {
                    board[i, j] = CountAdjacentMines(board, i, j);
                }
            }
        }
    }

    static int CountAdjacentMines(int[,] board, int row, int col)
    {
        int count = 0;
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int newRow = row + i;
                int newCol = col + j;
                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && board[newRow, newCol] == -1)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

