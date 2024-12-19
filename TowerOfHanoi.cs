//Este ejercicio te ayuda a practicar la implementación recursiva del problema clásico de la Torre de Hanoi. Mejora tu comprensión de la recursividad y cómo aplicarla para resolver problemas complejos de manera elegante.
public class TowerOfHanoi
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Torre de Hanoi");

        int[][] towers = new int[][]
        {
            new int[] {3, 2, 1},
            new int[] {},
            new int[] {}
        };

        Console.WriteLine("Torres iniciales:");
        PrintTowers(towers);

        towers = SolveHanoi(towers, 3);

        Console.WriteLine("\nTorres finales:");
        PrintTowers(towers);

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static int[][] SolveHanoi(int[][] towers, int n)
    {
        MoveDisks(n, 0, 2, 1, towers);
        return towers;
    }

    static void MoveDisks(int n, int source, int destination, int auxiliary, int[][] towers)
    {
        if (n == 1)
        {
            int disk = towers[source][towers[source].Length - 1];
            towers[source] = towers[source].Take(towers[source].Length - 1).ToArray();
            towers[destination] = towers[destination].Concat(new int[] { disk }).ToArray();
        }
        else
        {
            MoveDisks(n - 1, source, auxiliary, destination, towers);
            MoveDisks(1, source, destination, auxiliary, towers);
            MoveDisks(n - 1, auxiliary, destination, source, towers);
        }
    }

    static void PrintTowers(int[][] towers)
    {
        for (int i = 0; i < towers.Length; i++)
        {
            Console.Write($"Torre {i}: ");
            Console.WriteLine(string.Join(", ", towers[i]));
        }
    }
}

