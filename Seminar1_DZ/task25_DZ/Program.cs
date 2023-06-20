/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double Exponential(double x, double y)
{
    double result = Math.Pow(x, y);
    return result;
}

System.Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Число {num1} в степени {num2} = {Exponential(num1, num2)}");
