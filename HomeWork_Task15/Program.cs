System.Console.Write("Введите цифру дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 7)
{
    if (a == 6 || a == 7)
    {
        System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("No");
}
else System.Console.WriteLine("Не является днем недели");