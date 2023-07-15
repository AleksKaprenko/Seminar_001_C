/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int CountingDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите N-значное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (CountingDigit(number) == 0)
{
    System.Console.WriteLine("Число состоит из 1 цифры");
}
else
{
    System.Console.WriteLine($"Число состоит из {CountingDigit(number)} цифр");
}