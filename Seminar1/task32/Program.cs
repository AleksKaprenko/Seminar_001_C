/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] FillArrayRandom(int size) 
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(-99, 100);
    }
    return array;
}

int[] ArrayRevert(int[] array)
{
    int[] NewArr = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        NewArr[i] = -array[i];
    }
    return NewArr;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: [{string.Join("; ", array)}]");
int[] NewArr = ArrayRevert(array);
System.Console.WriteLine($"перевернутый массив: [{string.Join("; ", NewArr)}]");
