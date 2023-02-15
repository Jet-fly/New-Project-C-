/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

System.Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int[,] mat = new int[m, n];

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i, j] = rnd.Next(0, 100);
        System.Console.Write("  " + mat[i, j]);
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите столбец: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите строку: ");
int b = Convert.ToInt32(Console.ReadLine());
if ((a > 0 && a <= n) && (b > 0 && b <= m))
{
    System.Console.WriteLine("Ваш элемент: " + mat[b-1,a-1]);
}
else
{
    System.Console.WriteLine("Такого элемента нет");
}