Console.Write("Введите число: ");
string number = Console.ReadLine();

ThirdRank(number);

void ThirdRank(string msg)
{
    if (number.Length >= 3) Console.WriteLine(number[2]);
    else Console.WriteLine("Третьей цифры нет!");
}