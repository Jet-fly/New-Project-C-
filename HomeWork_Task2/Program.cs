Console.Write("Type a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Type b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max;

if (a > b)
{
    max = a;
    Console.WriteLine("Max = " + a);
}
else
{
    max = b;
    Console.WriteLine("Max = " + b);
}