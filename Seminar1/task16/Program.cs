/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

void PatrulQuater(int number1, int number2)
{
    if (number1*number1 == number2 || number2*number2 == number1)
{
    if (number1<number2)
    {
        Console.WriteLine($"число2 -> {number2} является квадратом числа1 -> {number1}");
    }
    else
    {
        Console.WriteLine($"число1 -> {number1} является квадратом числа2 -> {number2}");
    }
}
else 
{
    Console.WriteLine("Ни одно число не является квадратом другого");
}
}


Console.WriteLine("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
PatrulQuater(num1, num2);

/*
if (number1*number1 == number2 || number2*number2 == number1)
{
    if (number1<number2)
    {
        Console.WriteLine($"число2 -> {number2} является квадратом числа1 -> {number1}");
    }
    else
    {
        Console.WriteLine($"число1 -> {number1} является квадратом числа2 -> {number2}");
    }
}
else 
{
    Console.WriteLine("числа не являются квадратом");
}
*/