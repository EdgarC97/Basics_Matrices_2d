//Este ejercicio te ayuda a practicar la implementación de una versión simplificada del juego Tetris. Mejora tu habilidad para manejar la caída y colocación de piezas en un tablero 2D, así como la detección de colisiones y la búsqueda de la posición más baja posible para cada pieza. Este problema combina la manipulación de matrices 2D con la lógica de juegos, lo que te ayuda a desarrollar habilidades importantes para la programación de videojuegos y simulaciones.

public class SimplifiedTetris
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Tetris Simplificado");

        int[][] board = new int[][]
        {
            new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0}
        };

        int[][][] pieces = new int[][][]
        {
            new int[][] { new int[] {1, 1}, new int[] {1, 1} },
            new int[][] { new int[] {1, 1, 1} },
            new int[][] { new int[] {1}, new int[] {1} }
        };

        Console.WriteLine("Tablero inicial:");
        PrintBoard(board);

        board = PlayTetris(board, pieces);

        Console.WriteLine("\nTablero final:");
        PrintBoard(board);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static int[][] PlayTetris(int[][] board, int[][][] pieces)
    {
        foreach (var piece in pieces)
        {
            PlacePiece(board, piece);
        }
        return board;
    }

    static void PlacePiece(int[][] board, int[][] piece)
    {
        int pieceWidth = piece[0].Length;
        int pieceHeight = piece.Length;
        int boardWidth = board[0].Length;

        int lowestRow = 0;
        bool canPlace = false;

        for (int row = 0; row <= board.Length - pieceHeight; row++)
        {
            if (CanPlacePieceAt(board, piece, row, 0))
            {
                lowestRow = row;
                canPlace = true;
            }
            else if (canPlace)
            {
                break;
            }
        }

        if (canPlace)
        {
            for (int i = 0; i < pieceHeight; i++)
            {
                for (int j = 0; j < pieceWidth; j++)
                {
                    if (piece[i][j] == 1)
                    {
                        board[lowestRow + i][j] = 1;
                    }
                }
            }
        }
    }

    static bool CanPlacePieceAt(int[][] board, int[][] piece, int row, int col)
    {
        for (int i = 0; i < piece.Length; i++)
        {
            for (int j = 0; j < piece[i].Length; j++)
            {
                if (piece[i][j] == 1)
                {
                    if (row + i >= board.Length || col + j >= board[0].Length || board[row + i][col + j] == 1)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    static void PrintBoard(int[][] board)
    {
        foreach (var row in board)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

