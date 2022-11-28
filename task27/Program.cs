/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

int number = new int();
Console.WriteLine("Введите число:");
number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int a = number % 10;
        sum = sum + a;
        int b = number / 10;
        number = b;
    }
    return sum;
}

int sum = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} равно {sum}");



