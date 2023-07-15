// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Возведение в степень
// double number = 9;
// System.Console.WriteLine(Math.Pow(number, 2));
// Извлечение квадратного корня
// System.Console.WriteLine(Math.Sqrt(number));
// Округление дробного числа
// double num = 1.123213213213;
// System.Console.WriteLine(Math.Round(num, 2));
// Комбинация
// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));

double Line(double x1, double x2, double y1, double y2)
{
    double lineX = x2-x1;
    double lineY = y2-y1;
    double lineBig = Math.Sqrt(Math.Pow(lineX, 2)+Math.Pow(lineY, 2));
    return Math.Round(lineBig, 2);
}
Console.WriteLine("Введите координату Х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Расстояние между точками в 2D: {Line(x1, x2, y1, y2)}");