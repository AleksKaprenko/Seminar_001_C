/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

string CheckTriangle(int a, int b, int c)
{
    string result = "NO";
    if (a<b+c && b<a+c && c<a+b) return result="YES";
 return result;
}

System.Console.Write("Cторона треугольника a: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Cторона треугольника b: ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Cторона треугольника c: ");
int c = int.Parse(Console.ReadLine());
// string result = $"Треугольник с длинами сторон {a}, {b}, {c} ";
System.Console.WriteLine(CheckTriangle(a, b, c));
//Console.ReadKey();
// if (CheckTriangle(a, b, c) == true)
// {
// System.Console.WriteLine(result + "можно построить.");
// }
// else System.Console.WriteLine(result + "построить НЕЛЬЗЯ.");

