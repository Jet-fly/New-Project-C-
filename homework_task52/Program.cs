/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

System.Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[,] mat = new int[m, n];

double sred = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i, j] = rnd.Next(0, 100);
        System.Console.Write(mat[i, j] + "\t");

    }
    System.Console.WriteLine();
}

for (int i = 0; i < mat.GetLength(1); i++)
{
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        sred = sred + mat[j,i];
    }
    sred = sred / mat.GetLength(0);
    System.Console.WriteLine($"Столбец {i+1} = " + "{0:F1}", sred);
    sred = 0;
}
