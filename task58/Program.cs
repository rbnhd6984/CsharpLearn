// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
    
// Создаем две матрицы
int[,] matrix1 = new int[,]
{
    { 2, 4 },
    { 3, 2 }
};
int[,] matrix2 = new int[,]
{
    { 3, 4 },
    { 3, 3 }
};

// Выводим исходные матрицы на экран
Console.WriteLine("Исходная матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Исходная матрица 2:");
PrintMatrix(matrix2);

// Находим произведение матриц
int[,] result = MultiplyMatrices(matrix1, matrix2);

// Выводим результат на экран
Console.WriteLine("Результат:");
PrintMatrix(result);


int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    // Получаем количество строк и столбцов в каждой матрице
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    // Проверяем, можно ли умножить матрицы
    if (cols1 != rows2)
    {
        throw new ArgumentException("Матрицы несовместимы для умножения");
    }

    // Создаем новую матрицу для хранения результата
    int[,] result = new int[rows1, cols2];

    // Проходим по каждой строке матрицы 1
    for (int i = 0; i < rows1; i++)
    {
        // Проходим по каждому столбцу матрицы 2
        for (int j = 0; j < cols2; j++)
        {
            // Вычисляем значение ячейки результата
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    // Возвращаем результат
    return result;
}

static void PrintMatrix(int[,] matrix)
{
    // Получаем количество строк и столбцов в матрице
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    // Проходим по каждой строке матрицы
    for (int i = 0; i < rows; i++)
    {
        // Проходим по каждому столбцу матрицы
        for (int j = 0; j < cols; j++)
        {
            // Выводим элемент на экран с пробелом после него
            Console.Write("{0} ", matrix[i, j]);
        }
        // Переводим строку после вывода всех элементов в строке
        Console.WriteLine();
    }
}