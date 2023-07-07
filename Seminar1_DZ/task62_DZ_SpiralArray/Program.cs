/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillMatrixWithRandom(int[,] matrix)
{

    Random rnd = new Random();
    int step = 0;
    int pivotNumber = 1;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int countX = rows / 2;
    int countY = columns / 2;

    for (int cycle = 0; cycle <= countX; cycle++)
    {


        for (int i = 0 + step; i < step + 1; i++) // заполнение сверху слева -> вправо
        {
            for (int j = 0 + step; j < columns - step; j++)
            {
                matrix[i, j] = pivotNumber + j;
            }
        }
        pivotNumber = matrix[0 + step, columns - step - 1];
        System.Console.WriteLine(pivotNumber);

        for (int i = 0 + step; i < rows - step; i++)  // заполнение сверху справа - > вниз
        {
            for (int j = columns - step - 1; j >= columns - step - 1; j--)
            {
                matrix[i, j] = pivotNumber + i;
                //  System.Console.WriteLine( matrix[i, j]);
            }
        }
        pivotNumber = matrix[rows - step - 1, columns - step - 1];
        System.Console.WriteLine(pivotNumber);

        for (int i = rows - step - 1; i >= rows - step - 1; i--) // заполнение снизу справа - > влево
        {
            {
                for (int j = columns - step - 1; j >= 0 + step; j--)
                {
                    matrix[i, j] = pivotNumber + columns - j - 1;
                }
            }
            pivotNumber = matrix[rows - step - 1, 0 + step];
            System.Console.WriteLine(pivotNumber);
        }

        for (int i = rows - step - 1; i > 0 + step; i--)  // заполнение снизу слева - > вверх
        {
            for (int j = 0 + step; j >= 0 + step; j--)
            {
                matrix[i, j] = pivotNumber + rows - i - 1;
            }
        }
        pivotNumber = matrix[0 + step + 1, 0 + step];
        System.Console.WriteLine(pivotNumber);

        step++;
    }

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);