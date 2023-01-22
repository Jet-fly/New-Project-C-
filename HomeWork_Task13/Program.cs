System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (a/10 != 0)
{
    count++;
}
System.Console.WriteLine("count = " + count);