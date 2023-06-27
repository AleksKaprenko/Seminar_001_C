/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] FillArrayRandomDouble(int size) // метод заполнения массива произвольными вещественными числами
{
double[] array = new double[size]; 
Random rnd = new Random();
//double minRange = -100, maxRange = 100; // для вар 1:  мин. и max граница генерируемых чисел, задаем произвольно
for (int i = 0; i<size; i++)
    {
   // array[i] = Math.Round((rnd.NextDouble() *(maxRange-minRange) + minRange), 2); // вар 1: random в диапазоне (minRange, maxRange) с округлением до 2 знаков
  array[i] = Math.Round((rnd.NextDouble() + rnd.Next(-100, 100)), 3); // вариант 2 random
    }
    return array;
}

double MaxSubMin(double[] array)
{
        double max=array[0], min=array[0];
        for (int i=1; i<array.Length; i++)
            if (array[i]>max) max=array[i]; 
            else if (array[i]<min) min=array[i]; 
        return (max-min);
}

System.Console.Write("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayRandomDouble(length);
System.Console.WriteLine($"\nВведен массив: \n[{string.Join("; ", array)}]\n");

//вариант 1 с использованием метода для поиска макс. и мин. в цикле и вычисления разницы
double sub = Math.Round(MaxSubMin(array), 2);
System.Console.WriteLine($"Вариант кода 1 (поиск мин и макс в цикле). Разница между max и min равна {sub}\n");

//вариант 2 без доп. метода используя встроенные функции массива
System.Console.WriteLine($"Вариант кода 2. Разница между max ({array.Max()}) и min ({array.Min()}) равна {Math.Round((array.Max() - array.Min()), 2)}");