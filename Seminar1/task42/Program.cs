/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

void DecToBinary(int a) // рекурсия
{
   if (a == 0)
    {
        return;
    }
    DecToBinary(a/2);
    System.Console.Write(a%2);    
}

System.Console.Write("Введите десятичное число: ");
int a = Convert.ToInt32(Console.ReadLine());
DecToBinary(a);
System.Console.WriteLine();
System.Console.Write(Convert.ToString(a, 2)); // преобразование int в строку - двоичное число