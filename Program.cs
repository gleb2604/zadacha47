/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

//                        строки     столбцы
double[,] GetRandomMatrix(int rows, int columns)
{
    Random random = new Random();
    double[,] matrix = new double[rows,columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            var a = matrix[i, j];
            //Console.Write($"{a:f2}" + "   ");
            Console.Write("{0,6:F2}", a);
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMNS = 4;

double[,] array = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(array);