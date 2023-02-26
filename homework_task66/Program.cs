/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int summa(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine("Сумма = " + summa(m,n));
