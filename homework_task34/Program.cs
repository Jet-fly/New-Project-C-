/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

System.Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(99,1000);
}

int count = 0;
for (int i = 0; i < n; i++)
{
    System.Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных = {count}");