int number = new Random().Next(100, 1000);
Console.WriteLine(number);

SecDigit(number);

void SecDigit(int num)
{
    int secDig = num / 10 % 10;
    Console.WriteLine(secDig);
}