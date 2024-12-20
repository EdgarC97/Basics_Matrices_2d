// Este ejercicio te ayuda a practicar la validación de reglas complejas en una estructura de datos 2D.
// Mejora tu habilidad para usar estructuras de datos como HashSet para verificar la unicidad de elementos en diferentes contextos.

public class ValidSudoku
{
    public static void Run()
    {
        // Mensaje de bienvenida al ejercicio
        Console.WriteLine("Ejercicio: Sudoku Válido");

        // Tablero de Sudoku 9x9 (algunos espacios están vacíos representados por '.')
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

        // Comprobamos si el Sudoku es válido
        bool isValid = IsValidSudoku(board);

        // Mostramos si el Sudoku es válido
        Console.WriteLine($"¿Es un Sudoku válido? {isValid}");

        // Fin del ejercicio
        Console.WriteLine("Ejercicio completado.");
        Console.WriteLine();
    }

    // Método para verificar si el Sudoku es válido
    static bool IsValidSudoku(char[,] board)
    {
        // Usamos un HashSet para almacenar las posiciones de los números ya vistos en filas, columnas y bloques
        HashSet<string> seen = new HashSet<string>();

        // Recorremos todas las celdas del tablero (9x9)
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                // Obtenemos el valor de la celda actual
                char current = board[i, j];

                // Si la celda no está vacía (es decir, tiene un número)
                if (current != '.')
                {
                    // Imprimimos el valor y la posición del número en la fila, columna y bloque
                    Console.WriteLine($"Verificando el número {current} en la posición ({i}, {j})");

                    // Verificamos si este número ya ha aparecido en la fila, columna o bloque
                    // Si es así, significa que el Sudoku no es válido
                    if (!seen.Add(current + " in row " + i) ||  // Verificamos si ya existe en la fila
                        !seen.Add(current + " in column " + j) ||  // Verificamos si ya existe en la columna
                        !seen.Add(current + " in block " + i / 3 + "-" + j / 3))  // Verificamos si ya existe en el bloque de 3x3
                    {
                        // Si encontramos un duplicado, el Sudoku no es válido
                        Console.WriteLine($"¡El número {current} ya existe en la fila {i}, columna {j} o bloque!");
                        return false;
                    }
                }
            }
        }

        // Si no encontramos ningún duplicado, el Sudoku es válido
        return true;
    }
}
