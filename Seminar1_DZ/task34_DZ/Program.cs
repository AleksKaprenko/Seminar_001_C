/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] FillArrayRandom(int size) // метод заполнения массива случайными целыми числами
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(100, 1000); //генерирование случайного целого от 100 до 999
    }
    return array;
}

int CountEvenElements(int[] array)
{
        int count=0;
        for (int i=0; i<array.Length; i++)
            if (array[i]%2==0) // проверка четности числа
            {
               count++; 
            }
        return count;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"\nВведен массив:\n[{string.Join("; ", array)}]\n");
int count = CountEvenElements(array);
System.Console.WriteLine($"В массиве {count} четных чисел");