Console.Write("Type a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Type b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Type c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max;

if (a > b)
{
    if (a > c)
    {
        max = a;
        Console.WriteLine("Max a = " + a);
    }
    else
    {
        max = c;
        Console.WriteLine("Max c = " + c);
    }
}
else
{
    if (b > c)
    {
        max = b;
        Console.WriteLine("Max b = " + b);
    }
    else
    {
        max = c;
        Console.WriteLine("Max c = " + c);
    }
}