// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] SortFromBiggestToSmall(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = j + 1; q < matrix.GetLength(1); q++)
            {
                if (matrix[i,j] < matrix[i,q])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,q];
                    matrix[i,q] = temp;
                }
            }
        }
    }
    return matrix;
}
int[,] matrix2d = RandomMatrix(1,10);
PrintMatrix(matrix2d);
System.Console.WriteLine();
int[,] sortedmatrix = SortFromBiggestToSmall(matrix2d);
PrintMatrix(sortedmatrix);