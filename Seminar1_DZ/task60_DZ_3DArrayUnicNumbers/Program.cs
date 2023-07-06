/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillMatrix3D(int[,,] matrix3D) // метод для заполнения 3-мерного массива произвольными но уникальными 2-значными целыми числами
{
    Random rnd = new Random();
    int temp;
    int size = 180; // задаем явно размер коллекции (массив), которая будет содержать все уникальные целые 2-значные числа (отриц. + положит.)
    List<int> library = new List<int>(size);
    for (int i = size / 2 - 1; i >= 0; i--)  library.Add(-i - 10); // последовательное добавление в коллекцию всех уникальных целых отрицательных 2-значных чисел (-99 ... -10)
    for (int i = 0; i < size / 2; i++) library.Add(i + 10); // последовательное добавление в коллекцию всех уникальных целых положительных 2-значных чисел (10 ... 99)

    for (int i = library.Count - 1; i >= 1; i--) // перемешать произвольным образом сфорированный список
    {
        int j = rnd.Next(i + 1);
        temp = library[j];
        library[j] = library[i];
        library[i] = temp;
    }

    // foreach (int r in library) System.Console.Write($"{r} "); // последовательный вывод всех элементов коллекции на экран

    // заполнение 3-мерной матрицы целыми числами
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                temp = rnd.Next(library.Count); // произвольный индекс #temp из всей длины коллекции
                matrix3D[i, j, k] = library[temp]; // присвоение элемента коллекции с индексом #temp элементу массива
                library.RemoveAt(temp); // удаление из коллекции использованного элемента с индексом #temp 
            }
        }
    }
}

void PrintMatrix3D(int[,,] matrix3D) // вывод на экран элементов массива с их индексами 
{
    System.Console.WriteLine("\nВывод методом прямого посвледовательного перебора\n");
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                System.Console.Write($"{matrix3D[i, j, k]} \t({i},{j},{k})    |\t");
            }
            System.Console.WriteLine();
        }
    }
    System.Console.WriteLine("\nВывод как указано в примере к задаче\n");
    for (int x = 0; x < matrix3D.GetLength(2); x++)
    {
        for (int z = 0; z < matrix3D.GetLength(0); z++)
        {
            for (int y = 0; y < matrix3D.GetLength(1); y++)
            {
                System.Console.Write($"{matrix3D[z, y, x]} \t({z},{y},{x})    |\t");
            }
            System.Console.WriteLine();
        }
    }
}

System.Console.WriteLine("Задайте параметры 3-мерной матрицы для заполнения уникальными целыми 2-значными числами (максимум 6x6x5):");
System.Console.Write("размерность X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("размерность Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("размерность Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int[x, y, z];

if (x + y + z < 18) // проверяем, чтобы для матрицы заданной длины хватило уникальных целых 2-значных чисел (их существует всего 180)
{
    FillMatrix3D(matrix3D);
    PrintMatrix3D(matrix3D);
}
else System.Console.WriteLine("Заполнить матрицу такого размера уникальными целыми 2-значными числами невозможно");
