// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (res < arg2) res = arg2;
    if (res < arg3) res = arg3;
    return res;
}

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

int max = Max(a, b, c);

Console.WriteLine("Максимальное число - " + max);