/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/


string[] quaterarray = {"x>0 , y>0" , "x<0 , y>0" , "x>0 , y>0" , "x<0 , y>0"};
Start:
Console.WriteLine("Введите номер четверти:");
int x = Convert.ToInt32(Console.ReadLine());

if (x>=1 && x<=4)
{
Console.WriteLine(quaterarray[x-1]);
}
else 
{
    Console.WriteLine("Введен неверный номер четверти.");
    goto Start;
}