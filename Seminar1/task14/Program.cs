/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/
void PrintMultiple(int num)
{
    if (num %7==0 && num %23==0)
    {
        Console.WriteLine($"число {num} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"число {num} не кратно 7 и 23");
    }
}




Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintMultiple(number);

/*if (number %7==0 && number %23==0)
{
    Console.WriteLine($"число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"число {number} не кратно 7 и 23");
}
*/