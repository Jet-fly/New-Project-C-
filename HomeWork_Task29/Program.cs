/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Random rnd = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,100);
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"[{i+1}] = {array[i]}");
}