int a = new Random().Next(100,1000);

int b = ((a/100)*10) + (a%10);

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);