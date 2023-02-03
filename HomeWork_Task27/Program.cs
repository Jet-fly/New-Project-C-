/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (a != 0)
{
    b = b + (a % 10);
    a = a / 10;
}
System.Console.WriteLine("Result = " + b);