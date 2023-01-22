/* System.Console.Write("Введите цифру дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 7)
{
    if (a == 6 || a == 7)
    {
        System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("No");
}
else System.Console.WriteLine("Не является днем недели"); */

System.Console.Write("Введите цифру дня недели: ");
string? a = Console.ReadLine();

switch (a)
{
    case "1": System.Console.WriteLine("No"); break;
    case "2": System.Console.WriteLine("No"); break;
    case "3": System.Console.WriteLine("No"); break;
    case "4": System.Console.WriteLine("No"); break;
    case "5": System.Console.WriteLine("No"); break;
    case "6": System.Console.WriteLine("Yes"); break;
    case "7": System.Console.WriteLine("Yes"); break;
    default: System.Console.WriteLine("Не является днем недели"); break;
}