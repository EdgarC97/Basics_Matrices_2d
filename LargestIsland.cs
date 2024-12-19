//Este ejercicio te ayuda a practicar la implementación de algoritmos de búsqueda en profundidad (DFS) para resolver problemas de conectividad en matrices 2D. Mejora tu habilidad para contar áreas conectadas y manejar estructuras de datos complejas.

public class LargestIsland
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Isla más Grande");

        int[,] grid = new int[4, 5]
        {
            {1, 1, 0, 0, 0},
            {1, 1, 0, 0, 0},
            {0, 0, 1, 0, 0},
            {0, 0, 0, 1, 1}
        };

        int largestIsland = FindLargestIsland(grid);
        Console.WriteLine($"El área de la isla más grande es: {largestIsland}");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static int FindLargestIsland(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int maxArea = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i, j] == 1)
                {
                    maxArea = Math.Max(maxArea, DFS(grid, i, j));
                }
            }
        }

        return maxArea;
    }

    static int DFS(int[,] grid, int i, int j)
    {
        if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i, j] == 0)
            return 0;

        grid[i, j] = 0; // Marcamos como visitado
        int area = 1;

        area += DFS(grid, i + 1, j);
        area += DFS(grid, i - 1, j);
        area += DFS(grid, i, j + 1);
        area += DFS(grid, i, j - 1);

        return area;
    }
}

