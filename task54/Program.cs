// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

Console.WriteLine("Исходный массив:");
PrintArray(arr);

SortDescending(arr);

Console.WriteLine("Упорядоченный массив:");
PrintArray(arr);

static void SortDescending(int[,] array)
{
    // Проходим по каждой строке массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Проходим по каждому элементу в строке, кроме последнего
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            // Проходим по каждому элементу в строке, начиная со второго
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                // сравниваю, если второй и последующие элементы строки больше первого, на след итерации второго и т.д.
                if (array[i, k] > array[i, j])
                {
                    // выполняю обмен значениями
                    (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
                }
            }
        }
    }
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}