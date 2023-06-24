/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
using System;
Console.Write("Введите N-значное число: ");
string? number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
char[] array = number.ToCharArray();
bool equalNumbers = false;
for (int i=0; i<=array.Length/2; i++)
    {
        if (array[i] == array[(array.Length-1)-i]) equalNumbers = true;
        else equalNumbers = false;
    }
if (equalNumbers == true) Console.WriteLine($"число {number} является палиндромом");
else Console.WriteLine($"число {number} НЕ является палиндромом");