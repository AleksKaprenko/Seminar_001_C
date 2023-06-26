/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] FillArrayRandom(int size) //vметод заполнения массива случайными целыми числами
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i<size; i++)
    {
      array[i] = rnd.Next(-99, 100); // диапазон генерируемых случайных целых
    }
    return array;
}

int SummOddElements(int[] array)
{
        int summ=0;
        // вар1
        /*  for (int i=0; i<array.Length; i++)
            if (i%2==1) // определение нечетной позиции элемента массива. Первый элемент имеет позицию 0 (четная)
            {
               summ+=array[i]; 
            }*/
        //вар2
        for(int i=1; i<array.Length; i+=2) summ+=array[i]; // проход по нечетным элементам массива
        return summ;
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(length);
System.Console.WriteLine($"\nВведен массив: \n[{string.Join("; ", array)}]\n");
int summ = SummOddElements(array);
System.Console.WriteLine($"Сумма элементов нечетных позиций равна {summ}");