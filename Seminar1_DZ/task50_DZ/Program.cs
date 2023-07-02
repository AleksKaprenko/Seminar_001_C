/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void SearchElementPositionInMatrix(int[,] matrix, int row, int column) // метод поиска элемента массива [i, j] и вывода его на экран, если существует
{
    if (row == 0 || column == 0 || row >= matrix.GetLength(0) + 1 || column >= matrix.GetLength(1) + 1) //
    {
        System.Console.WriteLine("Такого элемента в массиве нет");
    }
    else System.Console.WriteLine($"Элемент {matrix[row - 1, column - 1]}\n");
}

string SearchElelmentInMatrix(int[,] matrix, int value) // метод поиска числа в массиве 
{
    string result = $"Элемента {value} в массиве нет.";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)
            {
                result=$"Элемент {value} находится в массиве: строка {i + 1}, колонка {j + 1}.";
                return result; // возврат позиции первого совпадения
            }
        }
    }
    return result;
}

System.Console.Write("Задайте количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.Write("Укажите строку искомого элемента: ");
int newRow = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите столбец искомого элемента: ");
int newColumn = Convert.ToInt32(Console.ReadLine());
SearchElementPositionInMatrix(matrix, newRow, newColumn);
System.Console.Write("\nУкажите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SearchElelmentInMatrix(matrix, number));