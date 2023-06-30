/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int CountPositiveNumbers(int value)
{
    int count = 0;
    for (int i = 1; i <= value; i++)
    {
        System.Console.Write($"Введите целое число #{i}: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

System.Console.Write("Укажите количество вводимых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Ведено чисел больше 0: {CountPositiveNumbers(number)}");

