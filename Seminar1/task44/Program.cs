/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] Fibo(int a)
{
    int[] fibo = new int[a];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i=2; i<a; i++)
            {
                fibo[i] = fibo[i-1]+fibo[i-2];
            }
        return fibo;
}

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=2)
{
System.Console.Write($"Последовательность Фибоначчи числа {a}: {string.Join(", ", Fibo(a))}");
}
else if (a==1) System.Console.Write($"Последовательность Фибоначчи числа {a}: 0, 1");
else System.Console.WriteLine("Ошибка ввода");