// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

long Degree(int baseNum, int degreeNum)
{
    long degree = baseNum;
    long result = baseNum;
    if (degreeNum == 0) return 1;
    for (int i = 1; i < degreeNum; i++)
    {
        result *= degree;
    }

    return result;
}

int numA = InputNum("Введите число А: ");
int numB = InputNum("Введите число В: ");
Console.WriteLine(Degree(numA, numB));