//Написать программу, кот на вход принимает число и выдает его квадрат

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quater = number * number;

Console.WriteLine($"Квадрат числа {number} равен {quater}");