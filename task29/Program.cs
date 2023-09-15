// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void FillArray()
{
    Random randInt = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        int value = randInt.Next(100);
        array[i] = value;
    }
}

void PrintArray(int[] arr)
{
    string result = String.Join<int>(", ", array);
    Console.Write(result);
}

FillArray();
PrintArray(array);