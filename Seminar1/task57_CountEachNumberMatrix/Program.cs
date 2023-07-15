/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/
using System.Diagnostics;

void FillMatrixWithRandom(int[,] matrix) // заполняем 2мерную матрицу произвольными целыми
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10000);
        }
    }
}

void PrintMatrix(int[,] matrix) // печать матрицы в консоль
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

void CountEachNumberMatrix(int[,] matrix) // посчет количества одинаковых элементов матрицы
{
    Stopwatch stopWatch = new Stopwatch(); // вспомогательная функция для опеделения времени работы метода
    stopWatch.Start();
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    List<int> library = new List<int>(rows * cols); // объявляем пустую коллекцию длиной = размеру матрицы
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++)
        {
            library.Add(matrix[i, j]); // добавляем в конец коллекции значения матрицы
        }
    }
    library.Sort(); // сортировка коллекции
    int count = 0;
    int len = library.Count;
    for (int k = library[0]; k <= library[^1]; k++) // инкрементальный перебор от мин. значения в коллекции до макс.  
    {
        count = 0;
        for (int i = 0; i < len; i++)
        {
            if (library[i] == k)
            {
                count++; // подсчет количества вхождений элемента в коллекции
            }
        }
        if (count > 0) System.Console.WriteLine($"Кол-во повторений для {k} = {count}"); // вывод в консоль
    }
    stopWatch.Stop(); // стоп таймер
    System.Console.WriteLine(stopWatch.Elapsed); // вывод в консоль время выполнения метода
}

System.Console.Write("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
int[,] newMatrix = matrix;
PrintMatrix(matrix);
CountEachNumberMatrix(matrix);