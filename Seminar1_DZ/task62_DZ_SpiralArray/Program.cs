/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillMatrixWithRandom(int[,] matrix)
{
    int step = 0; // начальное значение для циклов спирали по строкам матрицы
    int incrementalNumber = 1; // стартовое число для инкрементального спирального заполнения матрицы
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int maxNumber = rows * columns; // макс. число ячеек матрицы

    for (step = 0; step < rows / 2; step++)
    {
        for (int j = 0 + step; j < columns - step; j++) // заполнение сверху слева -> вправо
        {
            if (incrementalNumber > maxNumber) break; // выход при достижении инкрементом максимального значения (числа ячеек)
            else matrix[0 + step, j] = incrementalNumber++;
        }

        for (int i = 1 + step; i < rows - step; i++)  // заполнение сверху справа - > вниз
        {
            if (incrementalNumber > maxNumber) break; // выход при достижении инкрементом максимального значения (числа ячеек)
            else matrix[i, columns - step - 1] = incrementalNumber++;
        }

        for (int j = columns - step - 2; j >= 0 + step; j--) // заполнение снизу справа - > влево
        {
            if (incrementalNumber > maxNumber) break; // выход при достижении инкрементом максимального значения (числа ячеек)
            else matrix[rows - step - 1, j] = incrementalNumber++;
        }

        for (int i = rows - step - 2; i > 0 + step; i--)  // заполнение снизу слева - > вверх
        {
            if (incrementalNumber > maxNumber) break; // выход при достижении инкрементом максимального значения (числа ячеек)
            else matrix[i, 0 + step] = incrementalNumber++;
        }
    }

    if (rows % 2 == 1) // заполнение последней нечетной строки - центральной
    {
        for (int j = 0 + step; j < columns - step; j++) // заполнение сверху слева -> вправо
        {
            if (incrementalNumber > maxNumber) break; // выход при достижении инкрементом максимального значения (числа ячеек)
            else matrix[0 + step, j] = incrementalNumber++;
        }
    }
}

void PrintMatrix(int[,] matrix) // вывод матрицы на экран
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
if (row*column !=0)
{
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
}
else System.Console.WriteLine("Необходимо вводить ненулевые размеры матрицы!");