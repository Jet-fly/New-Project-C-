System.Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    int b = (a / 10) % 10;
    System.Console.WriteLine("b = " + b);
}
else System.Console.WriteLine("Введено не трехзначное число");