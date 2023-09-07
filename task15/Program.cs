Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine();
int weekDay = Convert.ToInt32(day);

checkWeekend(weekDay);

void checkWeekend(int num)
{
    if (num > 5 && num < 8) Console.WriteLine("Это выходной день :)");
    else if (num > 0 && num < 6) Console.WriteLine("Трудо выебудни :(");
    else Console.WriteLine("Такого дня недели не существует!");
}