/*Задача 35: Задайте одномерный массив из N случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] FillArrayRandom(int size) 
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(-500, 501);
    }
    return array;
}

int SearchInRange(int[] array)
{
        int count1=0;
        for (int i=0; i<array.Length; i++)
            if (array[i]>=10 && array[i]<=99) 
            {
               count1++; 
            }
        return count1;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: \n[{string.Join("; ", array)}]\n");
int count = SearchInRange(array);
System.Console.WriteLine($"В массиве: {count} элементов со значением в диапазоне [10, 99]");