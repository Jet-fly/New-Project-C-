/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
if (b != 0)
{
    for (int i = 0; i < b - 1; i++)
    {
        c = c * a;
    }
    System.Console.WriteLine($"Result = {c}");
}
else 
System.Console.WriteLine("Result = 1");