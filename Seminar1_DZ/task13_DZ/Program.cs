/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void PrintThirdDigit(string num)
{
    if (num.Length>2)
    {
        System.Console.Write($"Третья цифра введеного числа равна {num[2]}");
    }
    else
    {
        System.Console.WriteLine("Введенное число не является 3-значным. Повторите ввод.");
    }
}


Console.Write("Введите 3-значное число: ");
string N = Console.ReadLine();
N = String.Join("", N.Split('-', ',' ,'.'));
PrintThirdDigit(N);