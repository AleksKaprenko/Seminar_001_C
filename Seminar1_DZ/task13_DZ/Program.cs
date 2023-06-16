/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
using System.Diagnostics;

void PrintThirdDigit(string num)
{
    if (num.Length>2)
    {
        System.Console.WriteLine($"Третья цифра введеного числа равна {num[2]}");
    }
    else
    {
        System.Console.WriteLine("Введенное число не является 3-значным. Повторите ввод.");
    }
}

Console.Write("Введите 3-значное число: ");
string? N = Console.ReadLine();
if (N!=null)
{
var sw = new Stopwatch();
sw.Start();
N = String.Join("", N.Split('-', ',' ,'.'));
PrintThirdDigit(N);
sw.Stop();
Console.WriteLine($"Время выполнения - {sw.Elapsed}");
}
Console.WriteLine();
//string num = "123";
var sw1 = new Stopwatch();
sw1.Start();
if (int.TryParse(N, out int number))
{
    System.Console.WriteLine($"Третья цифра введеного числа равна {N[2]}");
}
else
{
    System.Console.WriteLine("не число");
}
sw1.Stop();
Console.WriteLine($"Время выполнения - {sw1.Elapsed}");