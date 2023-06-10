/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Задача определения максимального из трех целых чисел.");
Console.WriteLine(); // выводит доп. пустую строку
Console.Write("целое число #1: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("целое число #2: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write("целое число #3: ");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = N1;
if (N1 > N2) max = N1;
else max = N2;
if (N3 > max) max = N3;

if (N1==N2 && N2==N3) 
{
    Console.WriteLine($"Введены три одинаковых числа = {max}.");
}
else 
{
    Console.WriteLine($"Максимальное из трех введенных чисел = {max}");
} 
