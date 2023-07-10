/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillMatrixWithRandom(int[,] matrix)
{
    int step = 0;
    int incrementalNumber = 1;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int maxNumber = rows * columns;

    for (int cycle = 0; cycle < rows / 2; cycle++)
    {
        for (int j = 0 + step; j < columns - step; j++) // заполнение сверху слева -> вправо
        {
            if (incrementalNumber > maxNumber) break;
            else matrix[0 + step, j] = incrementalNumber++;
        }

        for (int i = 1 + step; i < rows - step; i++)  // заполнение сверху справа - > вниз
        {
            if (incrementalNumber > maxNumber) break;
            else matrix[i, columns - step - 1] = incrementalNumber++;
        }

        for (int j = columns - step - 2; j >= 0 + step; j--) // заполнение снизу справа - > влево
        {
            if (incrementalNumber > maxNumber) break;
            else matrix[rows - step - 1, j] = incrementalNumber++;
        }

        for (int i = rows - step - 2; i > 0 + step; i--)  // заполнение снизу слева - > вверх
        {
            if (incrementalNumber > maxNumber) break;
            else matrix[i, 0 + step] = incrementalNumber++;
        }
        step++;
    }

    if (rows % 2 == 1)
    {
        for (int j = 0 + step; j < columns - step; j++) // заполнение сверху слева -> вправо
        {
            if (incrementalNumber > maxNumber) break;
            else matrix[0 + step, j] = incrementalNumber++;
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

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);



// int[,] FillMatrixSnake(int row, int col)
// {
//   int[,] arr = new int[row, col];
//   int x = 0;
//   int y = 0;
//   int xk = 1;
//   int yk = 0;
//   int xmax = col - 1;
//   int xmin = 0;
//   int ymax = row - 1;
//   int ymin = 1;

//   for (int i = 1; i <= row * col; i++)
//   {
//     arr[y, x] = i;

//     if (xk == 1 && yk == 0 && (x + xk > xmax))
//     {
//       xk = 0;
//       yk = 1;
//       xmax--;
//     }
//     else if (xk == 0 && yk == 1 && (y + yk > ymax))
//     {
//       xk = -1;
//       yk = 0;
//       ymax--;
//     }
//     else if (xk == -1 && yk == 0 && (x + xk < xmin))
//     {
//       xk = 0;
//       yk = -1;
//       xmin++;
//     }
//     else if (xk == 0 && yk == -1 && (y + yk < ymin))
//     {
//       xk = 1;
//       yk = 0;
//       ymin++;
//     }
//     x = x + xk;
//     y = y + yk;

//   }
//   return arr;
// }

// void PrintMatrix(int[,] matrix)
// {

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       System.Console.Write($"{matrix[i, j]} \t");
//     }
//     System.Console.WriteLine();

//   }
// }



// System.Console.Write("Сколько строк? ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Сколько колонок? ");
// int column = Convert.ToInt32(Console.ReadLine());

// if (row * column <= 100)
// {
//   int[,] matrix = FillMatrixSnake(row, column);
//   PrintMatrix(matrix);
//   System.Console.WriteLine();
// }
// else
// {
//   System.Console.WriteLine("давай поменьше");
// }