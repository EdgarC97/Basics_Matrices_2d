using System;

public class GameOfLife3D
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Juego de la Vida en 3D");

        int[][][] grid = new int[2][][]
        {
            new int[2][] { new int[] {1, 1}, new int[] {1, 1} },
            new int[2][] { new int[] {1, 1}, new int[] {1, 1} }
        };

        Console.WriteLine("Estado inicial:");
        PrintGrid(grid);

        int[][][] newGrid = GameOfLife3DSimulation(grid);

        Console.WriteLine("\nSiguiente estado:");
        PrintGrid(newGrid);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static int[][][] GameOfLife3DSimulation(int[][][] grid)
    {
        int[][][] newGrid = new int[grid.Length][][];
        for (int i = 0; i < grid.Length; i++)
        {
            newGrid[i] = new int[grid[i].Length][];
            for (int j = 0; j < grid[i].Length; j++)
            {
                newGrid[i][j] = new int[grid[i][j].Length];
            }
        }

        for (int x = 0; x < grid.Length; x++)
        {
            for (int y = 0; y < grid[x].Length; y++)
            {
                for (int z = 0; z < grid[x][y].Length; z++)
                {
                    int liveNeighbors = CountLiveNeighbors(grid, x, y, z);
                    if (grid[x][y][z] == 1)
                    {
                        newGrid[x][y][z] = (liveNeighbors >= 4 && liveNeighbors <= 6) ? 1 : 0;
                    }
                    else
                    {
                        newGrid[x][y][z] = (liveNeighbors == 5) ? 1 : 0;
                    }
                }
            }
        }

        return newGrid;
    }

    static int CountLiveNeighbors(int[][][] grid, int x, int y, int z)
    {
        int count = 0;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                for (int dz = -1; dz <= 1; dz++)
                {
                    if (dx == 0 && dy == 0 && dz == 0) continue;
                    int nx = x + dx, ny = y + dy, nz = z + dz;
                    if (nx >= 0 && nx < grid.Length &&
                        ny >= 0 && ny < grid[nx].Length &&
                        nz >= 0 && nz < grid[nx][ny].Length)
                    {
                        count += grid[nx][ny][nz];
                    }
                }
            }
        }
        return count;
    }

    static void PrintGrid(int[][][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.WriteLine(string.Join(" ", grid[i][j]));
            }
            Console.WriteLine();
        }
    }
}

