//Z1.11. Найти: все трехзначные числа, чьи квадраты оканчиваются тремя цифрами, которые и составляют искомые числа;

int a;
int b;

for (int i = 100; i < 1000; i++)
{
    a = i * i;
    b = a % 1000;
    if (i == b)
    {
        System.Console.WriteLine($"Число: {i}");
        System.Console.WriteLine($"Квадрат числа: {a}");
        System.Console.WriteLine();
    }
}