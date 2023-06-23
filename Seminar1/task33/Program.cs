/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] FillArrayRandom(int size) 
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(0, 10);
    }
    return array;
}

bool ArrayCompare(int[] array, int n)
{
  
    for (int i=0; i<array.Length; i++)
    {
        if (n == array[i])
        {
           return true;
        }
    }
    return false;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: [{string.Join("; ", array)}]\n");
System.Console.Write("Введите поисковое число: ");
int n = Convert.ToInt32(Console.ReadLine());

//вар 1
if (ArrayCompare (array, n))
{
    System.Console.WriteLine($"Элемент {n} найден в массиве");
}
else System.Console.WriteLine($"Элемент {n} НЕ найден в массиве");

//вар 2
string isOk = "Элемент НЕ найден";
for (int i = 0; i < array.Length; i++)
{
    if (n == array[i])
    {
        isOk = "Элемент найден";
        break;
    }
    else isOk="Элемент НЕ найден";
}
System.Console.WriteLine(isOk);