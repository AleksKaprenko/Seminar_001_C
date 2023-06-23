/*Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

int[] FillArrayRandom(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"Введен массив: [{string.Join("; ", array)}]");
int SummPositive =0;
int SummNegatve =0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) SummPositive += array[i];
    else SummNegatve += array[i];
}
System.Console.WriteLine($"Сумма положит. чисел = {SummPositive}");
System.Console.WriteLine($"Сумма отриц. чисел = {SummNegatve}");


