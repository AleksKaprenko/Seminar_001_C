/*Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.*/


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

void FirstToLast(int[,] matrix)
{
    int temp;
    int len0 = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++) //
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[len0, j];
        matrix[len0, j] = temp;
    }
}


System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
FirstToLast(matrix);
PrintMatrix(matrix);