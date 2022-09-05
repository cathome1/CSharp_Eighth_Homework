// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] SuperMatrix()
{
    int count = 10;
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину матрицы");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] matrix = new int[rows,columns,depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix.GetLength(2); q++)
            {
                matrix[i,j,q] = count;
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int q = 0; q < arr.GetLength(2); q++)
            {
                System.Console.Write($"{arr[i,j,q]}[{i},{j},{q}] ");
            }
        }
        System.Console.WriteLine();
    }
}
int[,,] matrix3d = SuperMatrix();
PrintMatrix(matrix3d);