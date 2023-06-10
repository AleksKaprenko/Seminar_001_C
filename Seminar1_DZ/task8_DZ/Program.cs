/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Вывод всех четных чисел от 1 до N.");
Console.WriteLine(); // выводит доп. пустую строку
Console.Write("Введите число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // выводит доп. пустую строку
int count = 1;
if (N>0)
{
Console.Write($"Ряд четных чисел от 1 до {N}: ");
while (count <=N)
    {
        if (count%2==0)
            {
                Console.Write($"{count} ");
            }
    count++;
    }
    Console.WriteLine(); // выводит доп. пустую строку
}
else
{
    Console.WriteLine($"Введеное число = {N}. Условия программы не соблюдены."); 
    Console.WriteLine($"Выполните программу еще раз, введя число больше {N}.");
    Console.WriteLine(); // выводит доп. пустую строку
}    