//Este ejercicio te ayuda a practicar la validación de reglas complejas en una estructura de datos 2D. Mejora tu habilidad para usar estructuras de datos como HashSet para verificar la unicidad de elementos en diferentes contextos.
public class ValidSudoku
{
    public static void Run()
    {
        Console.WriteLine("Ejercicio: Sudoku Válido");

        char[,] board = new char[9, 9]
        {
            {'5','3','.','.','7','.','.','.','.'},
            {'6','.','.','1','9','5','.','.','.'},
            {'.','9','8','.','.','.','.','6','.'},
            {'8','.','.','.','6','.','.','.','3'},
            {'4','.','.','8','.','3','.','.','1'},
            {'7','.','.','.','2','.','.','.','6'},
            {'.','6','.','.','.','.','2','8','.'},
            {'.','.','.','4','1','9','.','.','5'},
            {'.','.','.','.','8','.','.','7','9'}
        };

        bool isValid = IsValidSudoku(board);
        Console.WriteLine($"¿Es un Sudoku válido? {isValid}");

        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    static bool IsValidSudoku(char[,] board)
    {
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char current = board[i, j];
                if (current != '.')
                {
                    if (!seen.Add(current + " in row " + i) ||
                        !seen.Add(current + " in column " + j) ||
                        !seen.Add(current + " in block " + i / 3 + "-" + j / 3))
                        return false;
                }
            }
        }
        return true;
    }
}

