// // Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 6, 7, 8"

void numbers(int m, int n)
{
    if (n == m)
    {
        System.Console.Write($"{n} ");
        return;
    }
    numbers(m, n-1);
    System.Console.Write($"{n} ");
}

System.Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целое число N > M: ");
int N = Convert.ToInt32(Console.ReadLine());
numbers(M, N);