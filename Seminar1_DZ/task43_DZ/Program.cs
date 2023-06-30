/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//
// преобразуем уравенения к виду:
// ур. 1: b1*y = a1*x +c1 => a1*x - b1*y + c1 = 0
// ур. 2: b2*y = a2*x +c2 => a2*x - b2*y + c2 = 0
//
System.Console.Write("Ведите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double y1 = -1, y2 = -1;// по условиям задачи y = -1 (после преобразования уравнений к виду a*x - b*y + c1 = 0)
if (k1 / y1 != k2 / y2) // в условии - проверка на параллельность прямых
{
    double x = (y1 * b2 - y2 * b1) / (k1 * y2 - k2 * y1); // если прямые не параллельны, вычисляем координату Х точки их пересечения
    double y = (b1 * k2 - b2 * k1) / (k1 * y2 - k2 * y1); // если прямые не параллельны, вычисляем координату Y точки их пересечения
    System.Console.WriteLine($"Координаты точки пересечения заданных прямых: [{x}, {y}]");
}
else System.Console.WriteLine("Прямые не пересекаются (параллельны)");