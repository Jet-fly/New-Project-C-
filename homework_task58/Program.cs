/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

int[,] mat1 = new int[m, n];
int[,] mat2 = new int[n, m];
int[,] resultMat = new int[m, m];

System.Console.WriteLine("\nFirstMatrix:");
// Заполнение матриц и вывод первой.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat1[i, j] = rnd.Next(0, 10);
        mat2[j, i] = rnd.Next(0, 10);
        System.Console.Write(mat1[i, j] + "\t");
    }
    System.Console.WriteLine();
}

// Вывод второй матрицы.
System.Console.WriteLine("\nSecondMatrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        System.Console.Write($"mat2[{i},{j}] = {mat2[i, j]}\t");
    }
    System.Console.WriteLine();
}

// Заполнение и вывод новой матрицы.
System.Console.WriteLine("\nNew matrix:");
int k = 0;
int res = 0;
while (k < m)
{
    for (int i = 0; i < mat1.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < mat2.GetLength(1) - 1; j++)
        {
            res = (mat1[i, j] * mat2[j, i]) + (mat1[i, j] * mat2[j, i]);
        }
        resultMat[k, i] = res;
        for (int j = 0; j < mat2.GetLength(1) - 1; j++)
        {
            res = (mat1[i, j] * mat2[j, i] + mat1[i, j] * mat2[j, i]);
        }
        resultMat[k, i + 1] = res;
    }
    k++;
}

for (int i = 0; i < resultMat.GetLength(0); i++)
{
    for (int j = 0; j < resultMat.GetLength(1); j++)
    {
        System.Console.Write(resultMat[i, j] + "\t");
    }
    System.Console.WriteLine();
}