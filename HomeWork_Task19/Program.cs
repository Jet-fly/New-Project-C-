System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int count = 0;

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

int[] number = new int[count];
for (int i = count-1; i >= 0; i--)
{
    number[i] = b % 10;
    b = b / 10;
}

bool f = true;
int k = 0;
int j = count -1;
while (k < j)
{
    if (number[k] != number[j])
    {
        f = false;
        System.Console.WriteLine("NO");
        break;
    }
    else
    {
        k++;
        j--;
    }
}
if(f)
{
    System.Console.WriteLine("YES");
}