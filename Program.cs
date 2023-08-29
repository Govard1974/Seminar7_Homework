
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        array[i, j] = random.NextDouble() * 20 - 10;
       }
    }

return array;
}

void Print2dArray(double[,] array)
{  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write($"{array[i, j]:F1}\t");
        }
        Console.WriteLine();
    }
}        

Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m, n);

Console.WriteLine("Массив, заполненный случайными вещественными числами:");
Print2dArray(array);
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.


/* 
int[,] array = CreateRandom2dArray(3, 3);
Print2dArray(array);

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int value = GetArrayElement(array, row, column);

if (value != int.MinValue)
{
    Console.WriteLine("Значение элемента с индексами [{0}, {1}]: {2}", row, column, value);
}    
    else
    {
        Console.WriteLine("Элемент с указанными индексами не существует.");
    }
    

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }

    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
            Console.WriteLine();
    }
}

int GetArrayElement(int[,] array, int row, int column)
{
    int numRows = array.GetLength(0);
    int numColumns = array.GetLength(1);

    if (row >= 0 && row < numRows && column >= 0 && column < numColumns)
    {
        return array[row, column];
    }
    else
    {
        return int.MinValue;
    }
}

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

/*

int numRows = 3;
int numColumns = 3;

int[,] array = CreateRandom2dArray(numRows, numColumns);

Console.WriteLine("Сгенерированный массив:");
Print2dArray(array);

CalculateColumnAverages(array);

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        array[i, j] = random.Next(-10, 11);
       }
    }

return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }    
}


void CalculateColumnAverages(int[,] array)
{

    int numRows = array.GetLength(0);
    int numColumns = array.GetLength(1);

    for (int j = 0; j < numColumns; j++)
    {
        int sum = 0;
        for (int i = 0; i < numRows; i++)
        {
            sum += array[i, j];
        }
    double average = (double)sum / numRows;
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {average:F2}");
    }
}
*/