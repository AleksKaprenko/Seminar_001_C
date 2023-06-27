/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

bool CheckTriangle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c<a+b) return true;
    else return false;
}

System.Console.Write("Укажите длину стороны треугольника 1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите длину стороны треугольника 2: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите длину стороны треугольника 3: ");
int c = Convert.ToInt32(Console.ReadLine());
string result = $"Треугольник с длинами сторон {a}, {b}, {c} ";
//CheckTriangle(a, b, c);
if (CheckTriangle(a, b, c) == true)
{
System.Console.WriteLine(result + "можно построить.");
}
else System.Console.WriteLine(result + "построить НЕЛЬЗЯ.");