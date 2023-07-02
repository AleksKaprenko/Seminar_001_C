﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/



void FillMatrixWithRandom(double[,] matrix)
{
    Random rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=Math.Round(rnd.Next(-10, 10)*rnd.NextDouble(), 1);
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} \t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);