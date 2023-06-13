/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int SecondDigit(int num2)
{
    int digit2=num2%100/10;
    return digit2;
}

Console.WriteLine(); // выводит доп. пустую строку

Start:
Console.Write("Введите 3-значное число: ");
int N = Convert.ToInt32(Console.ReadLine());
   if (N>99 && N<1000)
    {
      System.Console.Write("Вторая цифра введеного числа равна ");
      System.Console.WriteLine(SecondDigit(N));
    }
    else 
    {
        System.Console.WriteLine("Введенное число не является 3-значным. Повторите ввод.");
        System.Console.WriteLine();
        goto Start;
    }

