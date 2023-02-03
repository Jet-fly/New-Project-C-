/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

System.Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(-101, 100);
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    System.Console.Write(array[i] + " ");
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных позиций = {sum}");
