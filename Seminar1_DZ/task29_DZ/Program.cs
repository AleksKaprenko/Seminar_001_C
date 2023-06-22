/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] NewArray(int n) //метод ввода элементов массива с клавиатуры
{
int[] array = new int[n]; // объявление масива из n целых чисел
for (int i = 0; i<n; i++)
    {
        Console.Write($"Введите элемент массива # {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int n = 8;
// System.Console.Write("Укажите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Задан массив из {n} элементов: \n");
System.Console.Write($"\nВведен массив: [{string.Join(", ", NewArray(n))}]\n");