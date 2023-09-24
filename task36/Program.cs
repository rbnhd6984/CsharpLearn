// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray();
PrintArray(array);
Console.Write(CalcAmount(array));


// метод получения массива
int[] GetArray()
{
    Random rand = new Random();
    int size = rand.Next(1, 10);
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-50, 50);
    }

    return array;
}

// метод распечатки массива
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CalcAmount(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) summ += arr[i];
    }

    return summ;
}