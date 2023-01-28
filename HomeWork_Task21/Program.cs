Console.Write("Введите координаты точки A1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A3: ");
double xc = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B3: ");
double yc = Convert.ToDouble(Console.ReadLine());

double result = 0;

result = Math.Sqrt( Math.Pow(ya-xa,2) + Math.Pow(yb-xb,2) + Math.Pow(yc-xc,2) );
Console.WriteLine("result = {0:##.######}", result);