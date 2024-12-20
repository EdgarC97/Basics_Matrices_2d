using System;

public class FindPathInMaze
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Buscar Camino en Laberinto");

        int[,] maze = new int[5, 5]  // Laberinto más grande de 5x5
        {
            {0, 0, 0, 1, 0},
            {1, 1, 0, 1, 0},
            {0, 0, 0, 1, 0},
            {0, 1, 1, 1, 0},
            {0, 0, 0, 0, 0}
        };

        bool[,] visited = new bool[maze.GetLength(0), maze.GetLength(1)];
        bool[,] path = new bool[maze.GetLength(0), maze.GetLength(1)];

        bool hasPath = HasPath(maze, visited, path, 0, 0);

        // Mostrar el estado final del laberinto con el camino marcado
        Console.WriteLine($"¿Existe un camino? {hasPath}\n");

        // Imprimir el laberinto con el camino marcado
        PrintMaze(maze, path);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static bool HasPath(int[,] maze, bool[,] visited, bool[,] path, int x, int y)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        // Si alcanzamos la meta, retornamos true
        if (x == rows - 1 && y == cols - 1)
        {
            path[x, y] = true; // Marcamos la meta en el camino
            return true;
        }

        // Comprobamos los límites y si ya visitamos la celda o si es una pared
        if (x < 0 || x >= rows || y < 0 || y >= cols || maze[x, y] == 1 || visited[x, y])
            return false;

        visited[x, y] = true;

        // Intentamos movernos en las 4 direcciones posibles: abajo, arriba, derecha, izquierda
        if (HasPath(maze, visited, path, x + 1, y) ||  // Mover hacia abajo
            HasPath(maze, visited, path, x - 1, y) ||  // Mover hacia arriba
            HasPath(maze, visited, path, x, y + 1) ||  // Mover hacia la derecha
            HasPath(maze, visited, path, x, y - 1))    // Mover hacia la izquierda
        {
            path[x, y] = true; // Marcamos el camino
            return true;
        }

        return false; // No encontramos el camino
    }

    // Función para imprimir el laberinto con el camino marcado
    static void PrintMaze(int[,] maze, bool[,] path)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (path[i, j])
                    Console.Write(" * "); // Marca el camino
                else if (maze[i, j] == 1)
                    Console.Write(" # "); // Muestra una pared
                else
                    Console.Write(" . "); // Muestra una celda vacía
            }
            Console.WriteLine();
        }
    }
}
