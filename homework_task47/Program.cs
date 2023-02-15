/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

double[,] mat = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = rndGenDouble(-100, 100);
    }
}

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        System.Console.Write( "     " + "{0:F2}", mat[i,j]);
    }
    System.Console.WriteLine();
}

double rndGenDouble(int a, int b)
{
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;
}
