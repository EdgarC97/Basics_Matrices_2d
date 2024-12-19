using System;

public class FindPathInMaze
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Buscar Camino en Laberinto");

        int[,] maze = new int[3, 3]
        {
            {0, 0, 0},
            {1, 1, 0},
            {1, 1, 0}
        };

        bool[,] visited = new bool[maze.GetLength(0), maze.GetLength(1)];

        bool hasPath = HasPath(maze, visited, 0, 0);
        Console.WriteLine($"¿Existe un camino? {hasPath}");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static bool HasPath(int[,] maze, bool[,] visited, int x, int y)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        if (x == rows - 1 && y == cols - 1)
            return true;

        if (x < 0 || x >= rows || y < 0 || y >= cols || maze[x, y] == 1 || visited[x, y])
            return false;

        visited[x, y] = true;

        if (HasPath(maze, visited, x + 1, y) || HasPath(maze, visited, x - 1, y) ||
            HasPath(maze, visited, x, y + 1) || HasPath(maze, visited, x, y - 1))
            return true;

        return false;
    }
}

