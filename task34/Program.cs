// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = GetArray();
PrintArray(array);
Console.Write(CountPositive(array));



// метод получения массива
int[] GetArray()
{
    Random rand = new Random();
    int size = rand.Next(1, 10);
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    }

    return array;
}

// метод распечатки массива
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

// метод подсчета чётных чисел в массиве
int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }

    return count;
}