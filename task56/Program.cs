// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr2D =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int[] arr1D = new int [arr2D.GetLength(0)];

PrintTwoDimArray(arr2D);
Console.WriteLine();
int index = CalcSmallestAmount(arr2D);
Console.Write($"Номер строки с наименьшей суммой элементов {index + 1}.");

int CalcSmallestAmount(int[,] array)
{
    // блок кода для прохода по двумерному массиву и подсчету суммы его элементов
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int amount = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // суммирую элементы строк
            amount += array[i, j];
        }
        // добавляю в одномерный массив сумму пройденной строки
        arr1D[i] = amount;
    }
    
    // блок кода для прохода по одномерному массиву и поиска наименьшего числа
    int minIndex = 0;

    // Проходим по каждому элементу в массиве, начиная со второго
    for (int i = 1; i < arr1D.Length; i++)
    {
        // Если текущий элемент меньше элемента с индексом minIndex, обновляем minIndex
        if (arr1D[i] < arr1D[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

void PrintTwoDimArray(int[,] arrayTd)
{
    for (int i = 0; i < arrayTd.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTd.GetLength(1); j++)
        {
            Console.Write($"{arrayTd[i, j]}  ");
        }
        Console.WriteLine();
    }
}

