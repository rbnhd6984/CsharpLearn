// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = InputCoeff("Введите коэффициент k1: ");
double k2 = InputCoeff("Введите коэффициент k2: ");
double b1 = InputCoeff("Введите коэффициент b1: ");
double b2 = InputCoeff("Введите коэффициент b2: ");

LineIntersection();

// Функция ввода коэффициента
double InputCoeff(string msg)
{
    Console.Write(msg);
    double num = double.Parse(Console.ReadLine()!);
    return num;
}

// Функция нахождения точки пересечения двух прямых
void LineIntersection()
{
    if (k1 == k2)
    {
        // Если прямые параллельны, то выводим сообщение.
        Console.WriteLine("Прямые параллельны, точка пересечения не существует.");
    }
    else
    {
        // Находим точку пересечения.   
        double x = (b2 - b1) / (k1 - k2), y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения {x}, {y}");
    }
}

