/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double Distance = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)), 2);
    return Distance;
}
Console.Write("Введите координату Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Расстояние между точками в 3D: {Distance(x1, x2, y1, y2, z1, z2)}");