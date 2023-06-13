// программа выводит случайное число из (10, 99)  и показывает наибольшую цифру числа
 int DigitComparision(int num)
 {
    int digit1 = num /10;
    int digit2 = num%10;
    int result = 0;
    if (digit1>digit2)
    {
        result = digit1;
    }
    else 
    {
        result = digit2;
    }
    return result;
 }


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Макс цифра равна: {DigitComparision(number)}");
