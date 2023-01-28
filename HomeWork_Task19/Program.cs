System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int count = 0;
int i = 0;

// Считаем количество цифр:
while (b > 0)
{
    b = b / 10;
    count++;
}
if (count == 0) 
{
    count++;
}

System.Console.WriteLine("Количество цифр: " + count);
b = a;

// Вводим массив и записываем цифры числа:
int[] number = new int[count];
for (i = count-1; i >= 0; i--)
{
    number[i] = b % 10;
    b = b / 10;
}

// Проверка, является ли число палиндромом:
bool f = true;
i = 0;
int j = count - 1;
while (i < j)
{
    if (number[i] != number[j])
    {
        f = false;
        System.Console.WriteLine("NO");
        break;
    }
    else
    {
        i++;
        j--;
    }
}
if(f)
{
    System.Console.WriteLine("YES");
}