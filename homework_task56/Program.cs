/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

int[,] mat = new int[m, n];

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i,j] = rnd.Next(0,10);
        System.Console.Write(mat[i,j] + "\t");
    }
    System.Console.WriteLine();
}

int[] sumArray = new int[m];
int sum = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        sum = sum + mat[i,j];
    }
    sumArray[i] = sum;
    System.Console.WriteLine($"Сумма {i+1} строки: {sum}");
    sum = 0;
}

int min = sumArray[0];
int minIndex = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (min > sumArray[i])
    {
        min = sumArray[i];
        minIndex = i;
    }
}

System.Console.WriteLine($"Минимальная сумма строк: {min}");
System.Console.WriteLine($"Минимальная строка: {minIndex + 1}");