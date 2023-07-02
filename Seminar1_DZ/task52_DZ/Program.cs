/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillMatrixWithRandom(int[,] matrix) // метод заполнения массива произвольными целыми числами
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-9, 10);
        }
    }
}

void PrintMatrix(int[,] matrix) // метод вывода массива на экран
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

double[] AvarageOfColumn(int[,] matrix) // метод вычисления ср. арифметич. столбцов
{
    double[] avarage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avarage[j] = Math.Round(sum / matrix.GetLength(0), 3);
    }
    return avarage;
}

System.Console.Write("Задайте количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine($"\nСр. арифм. каждого столбца: \n[{string.Join("; ", AvarageOfColumn(matrix))}]\n");