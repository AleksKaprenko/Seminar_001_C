/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Задача определения максимального из двух чисел.");
Console.Write("Введите число #1: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Вариант кода #1 
Console.Write("Вариант кода #1 (if else): ");

if (N1>N2) 
{
    Console.WriteLine($"max = {N1}.");
}
else if (N2>N1)
{
    Console.WriteLine($"max = {N2}.");
}
else 
{
    Console.WriteLine($"Введены два одинаковых числа: {N1} = {N1}.");
}


// Вариант кода #2
Console.Write("Вариант кода #2 (тернарная операция): ");
int max = N1 > N2 ? (max=N1) : (max=N2); // Тернарная операция: если условие N1>N2 = true, выполяется 1я скобка, если false - вторая
if (N1==N2)
{
    Console.WriteLine($"Введены два одинаковых числа -> {N1} = {N1}.");
}
else Console.WriteLine($"max = {max}.");