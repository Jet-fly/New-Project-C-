System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int count = 1;

while (b/10 != 0) // Проверка количества цифр
{
    b = b/10;
    count++;
}
System.Console.WriteLine("Количество цифр: " + count);

int[] array = new int[count]; // Создали массив, в который запишем цифры числа в обратном порядке
for (int i = 0; i < count; i++)
{
    array[i] = a % 10;
    a = a / 10;
}

if (count >= 3) // Если количество цифр больше или равно 3, тогда...
{
    System.Console.WriteLine("Третья цифра: " + array[count-3]);
}
else System.Console.WriteLine("Третьей цифры нет");