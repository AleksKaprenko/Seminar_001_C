/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] RowToColumn(int[,] matrix) // вар.1 метод замены строк на столбцы через новую матрицу
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = matrix[j, i];
        }
    }
    return newArray;
}

int[,] RowToColumnReverce(int[,] matrix) // вар. 2 метод замены строк на столбцы через новую матрицу
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = newArray.GetLength(0)-1; i >=0; i--)
    {
        for (int j = newArray.GetLength(1)-1; j >=0; j--)
        {
            newArray[i, j] = matrix[j, i];
        }
    }
    return newArray;
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
int[,] newMatrix = matrix;
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(RowToColumn(matrix));
System.Console.WriteLine();
PrintMatrix(RowToColumnReverce(newMatrix));