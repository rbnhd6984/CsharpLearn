// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] myArray = UserInput();
Console.WriteLine(string.Join(", ", myArray));
int myCount = CountPositive(myArray);
Console.Write($"Пользователь ввёл {myCount} числа больше нуля.");


// Метод заполнения массива
int[] UserInput() 
{
    Console.Write("Введите размер массива: ");
    int arrSize = int.Parse(Console.ReadLine()!);
    int[] array = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"Введите число номер {i + 1}: ");
        int temp = int.Parse(Console.ReadLine()!);
        array[i] = temp;
    }

    return array;
}

// Метод подсчета числе больше нуля
int CountPositive(int[] arr) 
{
    int count = 0;
    foreach (var el in arr)
    {
        if (el > 0) count++;
    }

    return count;
}

