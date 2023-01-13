Console.Write("Type N: ");
int N = Convert.ToInt32(Console.ReadLine());
 
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0 && i != N && i != N-1)       // Сложные условия для красивого вывода.
    {
        Console.Write(i + ", ");
    }
    if (i % 2 == 0 && (i == N || i == N-1))
    {
        Console.Write(i + ". ");
    }
}
