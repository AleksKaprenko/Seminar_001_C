// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArrayRandom(int size) 
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(0, 100);
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    
    for (int i=0; i<arr.Length; i++)
    {
       newArray[i] = arr[i];
    }
    return newArray;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: [{string.Join("; ", array)}]\n");
System.Console.WriteLine($"новый массив (копия): [{string.Join("; ", CopyArray(array))}]\n");