/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ=0;
        System.Console.Write($"Строка {i+1}:\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
            summ += matrix[i, j]; // вычисление суммы элементов строки
        }

        System.Console.WriteLine($"| Сумма: {summ}"); // печать суммы элементов строки
    }
    System.Console.WriteLine();
}

int MinSumRow(int[,] matrix) // 
{
    int[] sumRow = new int[matrix.GetLength(0)]; // новый массив для хранения сумм строк вх. матрицы
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) summ += matrix[i, j]; // сумма строки вх. матрицы
        sumRow[i] = summ; // запись суммы строки вх. матрицы в новый массив
    }
    int minSum = 0;
    int minSumRow=-1;
    for (int k = 0; k < sumRow.Length; k++)
    {
        if (sumRow[k] < minSum) 
    // если несколько строк с одинаковой минимальной суммой элементов, то:
    // при условии "<=" в minSumRow сохраняется ПОСЛЕДНЯЯ из этих строк,
    // если "<" то ПЕРВАЯ
        {
            minSum = sumRow[k];
            minSumRow = k+1;
        }
    }
    return minSumRow;
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
int[,] newMatrix = matrix;
PrintMatrix(matrix);
int result = MinSumRow(matrix);
if (result !=-1)
{
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {result}.");
}
else System.Console.WriteLine("Ошибка программы");