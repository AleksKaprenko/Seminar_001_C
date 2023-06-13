/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

bool OddEven(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (OddEven(number1, number2))
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"НЕкратно. Остаток от деления {number2%number1}");
}

/*
if (number2 % number1 == 0)
{
Console.WriteLine("кратно");
}
else 
{
    Console.WriteLine($"НЕкратно. Остаток от деления {number2%number1}");
}
*/