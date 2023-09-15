// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AmountNum(int number)
{
    int result = 0;
    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

int num = InputNum("Введите число: ");
Console.WriteLine(AmountNum(num));