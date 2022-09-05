// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
bool flag = true;
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

int[,] MultipliMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0),arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int q = 0; q < arr1.GetLength(0); q++)
        {
            for (int i = 0; i < arr2.GetLength(1); i++)
            {
                int multipli = 0;
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    multipli = multipli + (arr1[q,j] * arr2[j,i]);
                }
                result[q,i] = multipli;
                
            }
        }
    }
    else if (flag == true) // перемена мест множителей
    {
        flag = false;
        return MultipliMatrix(arr2,arr1);
    }
    else if (flag == false)
    {
        System.Console.WriteLine("Умножение матриц с таким колличеством полей невозможно. Количество строк в одной из матриц, должно совпадать с количеством столбцов другой матрицы.");
    }
    return result;
}
int[,] mat1 = RandomMatrix(1,10);
int[,] mat2 = RandomMatrix(1,10);
System.Console.WriteLine("Первая Матрица");
PrintMatrix(mat1);
System.Console.WriteLine("Вторая Матрица");
PrintMatrix(mat2);
System.Console.WriteLine("Произведение матриц");
int[,] mult = MultipliMatrix(mat1,mat2);
PrintMatrix(mult);