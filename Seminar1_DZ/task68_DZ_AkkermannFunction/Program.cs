// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkermann(int m, int n)
{
    if (m==0) return n+1;
    if(m>0 && n==0) return Akkermann(m-1,1);
    if(m>0 && n>0) return Akkermann(m-1,Akkermann(m, n-1));
    return 0;
}

System.Console.Write($"Введите число 1:  ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите число 2:  ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана для чисел {m} и {n} = {Akkermann(m, n)}");
