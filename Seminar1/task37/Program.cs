/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] MultipleArray(int[] array)
{
    int newlength = array.Length/2 + array.Length%2; //
    int[] newArr = new int[newlength];
       for (int i=0; i<array.Length/2; i++)
            {
                newArr[i] = array[i]*array[array.Length-1-i];
            }
        if (array.Length%2==1) // если число эл. исх. массива нечетное
            {
                newArr[newlength-1]=array[array.Length/2]; //присваиваем последнему эл. newArr значение центрального эл. вх. массива
            }
        return newArr;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: [{string.Join("; ", array)}]\n");
int[] arr2 = MultipleArray(array);
System.Console.WriteLine($"новый массив: [{string.Join("; ", arr2)}]\n");