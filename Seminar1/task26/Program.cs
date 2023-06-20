/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите N-значное число: ");
string number = Console.ReadLine();
System.Console.WriteLine($"Количество цифр в числе {number} = {number.Length}");