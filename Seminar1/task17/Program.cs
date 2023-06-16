/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

void PrintQuater(int x, int y)
{
    if (x>0 && y>0)
        {
        System.Console.WriteLine("Точка в 1й четверти");
        }
    else if (x<0 && y>0)
        {
            System.Console.WriteLine("Точка в 2й четверти");
        }
    else if (x<0 && y<0)
        {
            System.Console.WriteLine("Точка в 3й четверти");
        }
    else if (x>0 && y<0)
        {
            System.Console.WriteLine("Точка в 4й четверти");
        }
     else 
        {
            System.Console.WriteLine("Точка лежит на оси");
        } 
}

Console.WriteLine("Введите координату Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());
PrintQuater(x, y);