//Este ejercicio te ayuda a practicar la implementación de la lógica del juego de la serpiente. Mejora tu habilidad para manejar estructuras de datos como LinkedList y trabajar con movimientos en una cuadrícula 2D.

public class SnakeGame
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Juego de la Serpiente");

        int[,] board = new int[3, 3]
        {
            {0, 0, 0},
            {1, 0, 2},
            {0, 0, 0}
        };

        string moves = "RRDL";

        int finalLength = PlaySnakeGame(board, moves);
        Console.WriteLine($"Longitud final de la serpiente: {finalLength}");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static int PlaySnakeGame(int[,] board, string moves)
    {
        int rows = board.GetLength(0), cols = board.GetLength(1);
        LinkedList<(int, int)> snake = new LinkedList<(int, int)>();
        snake.AddFirst((0, 0));

        int[] dx = { 0, 1, 0, -1 }; // R, D, L, U
        int[] dy = { 1, 0, -1, 0 };
        int direction = 0;

        foreach (char move in moves)
        {
            if (move == 'R') direction = 0;
            else if (move == 'D') direction = 1;
            else if (move == 'L') direction = 2;
            else if (move == 'U') direction = 3;

            var head = snake.First.Value;
            int newX = head.Item1 + dx[direction];
            int newY = head.Item2 + dy[direction];

            if (newX < 0 || newX >= rows || newY < 0 || newY >= cols ||
                (snake.Count > 1 && snake.Any(s => s.Item1 == newX && s.Item2 == newY)))
            {
                return snake.Count - 1;
            }

            snake.AddFirst((newX, newY));

            if (board[newX, newY] != 2)
            {
                snake.RemoveLast();
            }
        }

        return snake.Count - 1;
    }
}

