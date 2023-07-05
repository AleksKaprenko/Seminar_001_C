/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyMartix(int[,] matrix1, int[,] matrix2)
{
     int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    int[,] newMatrix = new int[rows1, cols2];
    for (int i = 0; i < rows1; i++) // #строк новой мартицы = #строк 1й матрицы
    {
        int sum = 0;

        for (int k = 0; k < cols2; k++) // #колонок новой мартицы = #колонок 2й матрицы
        {
            sum = 0;
            for (int m = 0; m < rows2; m++)
            {
                sum += matrix1[i, m] * matrix2[m, k];
            }
            newMatrix[i, k] = sum;
//            System.Console.WriteLine($"Сумма {sum}");
        }
    }
    return newMatrix;
}

System.Console.Write("количество строк матрицы #1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("количество столбцов матрицы #1: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[row1, column1];
System.Console.Write("количество строк матрицы #2: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("количество столбцов матрицы #2: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[row2, column2];
if (column1 != row2) // мартицы можно перемножить, если кол-во столбцов 1й матрицы равно кол-ву сток 2й
{
    System.Console.WriteLine("Перемножить матрицы невозможно");
    Environment.Exit(0); // прерывание выполнения программы
}
FillMatrixWithRandom(matrix1);
System.Console.WriteLine("\n[Матрица 1]");
PrintMatrix(matrix1);
FillMatrixWithRandom(matrix2);
System.Console.WriteLine("\n[Матрица 2]");
PrintMatrix(matrix2);
int[,] newArray = (MultiplyMartix(matrix1, matrix2));
System.Console.WriteLine("\n[Матрица 1 x Матрица 2]");
PrintMatrix(newArray);