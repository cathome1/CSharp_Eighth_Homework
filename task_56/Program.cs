// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
int[,] RandomMatrix(int min, int max)
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1)- 1) Console.Write($"{arr[i,j],5}, ");
            else Console.WriteLine($"{arr[i,j],5}]");
        }
    }
}
void MinimalSummRow(int[,]matrix)
{
    int minindx = 0;
    int min = 1000000000; // максимальное значение в матрице умноженное на количество столбцов
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (min > sum )
        {
            minindx = i;
            min = sum;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма чисел в {minindx + 1}й строке");
}
int[,] matrix2d = RandomMatrix(0,10);
PrintMatrix(matrix2d);
MinimalSummRow(matrix2d);