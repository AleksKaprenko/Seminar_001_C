// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ReverseOrderPrint(int number, int minNatural)
{
    if (minNatural==number)
    {
       System.Console.Write($"{number} ");
        return;
    }
    ReverseOrderPrint(number, minNatural+1);
    System.Console.Write($"{minNatural} ");
}
int minNatural = 1;
System.Console.Write($"Введите число больше {minNatural}:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=minNatural) ReverseOrderPrint(number, minNatural);
else System.Console.WriteLine("Ошибка. Выполните программу заново.");