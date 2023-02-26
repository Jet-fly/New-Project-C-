/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

System.Console.Write("Введите m: ");
uint m = Convert.ToUInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
uint n = Convert.ToUInt32(Console.ReadLine());

uint akkerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return akkerman(m - 1, 1);
    else
        return akkerman(m - 1, akkerman(m, n - 1));
}

uint res;
res = akkerman(m, n);
System.Console.WriteLine("akkerman(m, n) = " + res);