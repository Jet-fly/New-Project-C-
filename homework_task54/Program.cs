/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

System.Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int[,] mat = new int[m, n];

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i, j] = rnd.Next(0, 10);
        System.Console.Write(mat[i, j] + "\t");
    }
    System.Console.WriteLine();
}

// Построение новой матрицы
System.Console.WriteLine("\nNew Matrix:");
int temp;
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        for (int k = 1; k < mat.GetLength(1) - j; k++)
        {
            if (mat[i, k] > mat[i, k - 1])
            {
                temp = mat[i, k - 1];
                mat[i, k - 1] = mat[i, k];
                mat[i, k] = temp;
            }
        }
    }
}

// Вывод матрицы
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        System.Console.Write(mat[i, j] + "\t");
    }
    System.Console.WriteLine();
}