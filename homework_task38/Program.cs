/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

System.Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(-100, 100);
}

double max = array[0];
double min = array[0];
for (int i = 0; i < n; i++)
{
    System.Console.Write(array[i] + " ");
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
System.Console.WriteLine();
System.Console.WriteLine($"Max = {max}");
System.Console.WriteLine($"Min = {min}");
System.Console.WriteLine($"Result = {result}");