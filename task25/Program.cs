/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

int numberA = new int();
Console.WriteLine("Введите число A:");
numberA = Convert.ToInt32(Console.ReadLine());

int numberB = new int();
Console.WriteLine("Введите число B:");
numberB = Convert.ToInt32(Console.ReadLine());



int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
};

int output = Exponentiation(numberA, numberB);
Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равен {output}");
