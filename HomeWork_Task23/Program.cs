Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
double b = 0;

for (double i = 1; i <= n; i++)
{
    b = Math.Pow(i, 3);
    if ( i != n )
    {
        System.Console.Write(b + ", ");
    }
    else System.Console.Write(b + ".");
}