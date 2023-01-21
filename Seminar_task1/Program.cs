int a = new Random().Next(10,100);
Console.WriteLine("a = " + a);

int firstNumber = a / 10;
int secondNumber = a % 10;

if (firstNumber > secondNumber)
{
    Console.WriteLine("max = " + firstNumber);
}
else
{
    Console.WriteLine("max = " + secondNumber);
}