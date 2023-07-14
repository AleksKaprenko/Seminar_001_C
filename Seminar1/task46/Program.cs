/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] FillMatrixWithRandom(int[,] matrixWithRandom)
{
    Random rnd = new Random();
    int len0 = matrixWithRandom.GetLength(0);
    int len1 = matrixWithRandom.GetLength(1);
    for (int i=0; i<len0; i++)
    {
        for (int j=0; j<len1; j++)
        {
            matrixWithRandom[i,j]=rnd.Next(-99, 100);
        }
    }
    return matrixWithRandom;
}

void PrintMatrix(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
PrintMatrix(FillMatrixWithRandom(matrix));
