// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = GetArray();
PrintArray(array);
Console.WriteLine(Difference(array)); 


// метод получения массива
double[] GetArray()
{
    Random rand = new Random();
    int size = rand.Next(1, 10);
    double[] arrayIn = new Double [size];
    for (int i = 0; i < size; i++)
    {
        arrayIn[i] = Math.Round((rand.NextDouble() * 25), 2);
    }

    return arrayIn;
}

// метод распечатки массива
void PrintArray(double[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

// метод подсчета разницы
double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }

    double diff = max - min;
    return Math.Round(diff, 2);
}
