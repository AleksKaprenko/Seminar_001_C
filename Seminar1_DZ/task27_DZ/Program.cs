/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits_V1(int num) // вариант 1: вычисление через сумму остатков от деления на 10 в цикле
{
    int sum = 0;
    int CountOfDigits = 0;
    if (num>0)
    {
        CountOfDigits = Convert.ToString(num).Length; //количество цифр введенного положит. числа
        for (int i=1; i<=CountOfDigits; i++)
        {
            sum += num%10; 
            num /=10;
        }
    }
    else if (num<0)
    {
        CountOfDigits = Convert.ToString(Math.Abs(num)).Length; //количество цифр введенного отриц. числа
        for (int i=1; i<CountOfDigits; i++) // цикл суммирования без первой отриц. цифры 
        {
            sum += Math.Abs(num)%10;
            num /=10;
        }
        sum += num%(Convert.ToInt32(Math.Pow(10, CountOfDigits))); // первая отриц. цифра + сумма остальных цифр
    }
    return sum;
}

int SumOfDigits_V2(int num) // вариант 2: вычисление через преобразование символов в цифры
{
    int sum = 0;
    string digits = Convert.ToString(num); //преобразование в строку, чтобы обращаться к элементам (цифрам) числа
    if (digits[0] !='-') // если первый символ не равен "-", то суммируем начиная с первой цифры
    {
        for (int i = 0; i < digits.Length; i++)
        {
//преобразование символа цифры в целое число и суммирование. 
//Конструкция Convert.ToInt32(digits[i]) преобразовывает символ в его цифровой код по UTF-16
        sum = sum + (int)char.GetNumericValue(digits[i]); 
        }
    }
    //если введено отрицательное число, (первый символ равен "-"), то пропускаем символ "-",
    //преобразовываем второй символ (цифру) в отрицательное число    
    //и начинаем суммировать с него
    else 
    {
       sum = -(int)char.GetNumericValue(digits[1]); // первод второго символа (цифры) в отрицательное число
       if (digits.Length>2) //если введенное отриц. число содержит более 2 символов (знак "-" и одна цифра, напр. -5)
        {
            for (int i = 2; i < digits.Length; i++)
            {
            sum = sum + (int)char.GetNumericValue(digits[i]);   
            }
        }
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"\nВариант кода 1:\nСумма всех цифр числа {number} = {SumOfDigits_V1((number))}");
System.Console.WriteLine($"\nВариант кода 2:\nСумма всех цифр числа {number} = {SumOfDigits_V2((number))}");