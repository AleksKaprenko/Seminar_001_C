/* Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7
*/

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-99, 100);
        }
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

int[,] SearchMinValue(int[,] matrix)
{
    int min = matrix[0, 0];
    int RowToDel = -1, ColToDel = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                RowToDel = i;
                ColToDel = j;
            }
        }
    }
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i < RowToDel && j<ColToDel) newMatrix[i,j] = matrix[i,j];
            else if (i < RowToDel && j>=ColToDel) newMatrix[i,j] = matrix[i,j+1];
            else if (i >= RowToDel && j<ColToDel) newMatrix[i,j] = matrix[i+1,j];
            else newMatrix[i,j] = matrix[i+1,j+1];
        }
    }
return newMatrix;
}
/*
int[,] DeleteMinColRow(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];
    int minCol = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minCol = j;

            }
        }
    }

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i < minRow && j < minCol)
            {
                newMatrix[i, j] = matrix[i, j];
            }
            else if (i < minRow && j >= minCol)
            {
                newMatrix[i, j] = matrix[i, j + 1];
            }
            else
            {
                newMatrix[i, j] = matrix[i + 1, j + 1];
            }
        }
    }
    return newMatrix;
}
*/

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(SearchMinValue(matrix));
//System.Console.WriteLine();
//PrintMatrix(DeleteMinColRow(matrix));