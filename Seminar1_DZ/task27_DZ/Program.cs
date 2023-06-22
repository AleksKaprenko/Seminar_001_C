/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits(int num)
{
    int sum = 0;
    string digits = Convert.ToString(num); //преобразование в строку, чтобы обращаться к элементам (цифрам) числа
    if (digits[0] !='-') // если первый символ не равен "-", то далее суммируем начиная с первой цифры
    {
        for (int i = 0; i < digits.Length; i++)
        {
        sum = sum + (int)char.GetNumericValue(digits[i]); // перевод символа цифры в целое число, а не в код по UTF-16 и суммирование
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
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех цифр, составляющих число {number} = {SumOfDigits((number))}");