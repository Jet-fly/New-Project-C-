/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

System.Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[x, y, z];
Random rnd = new Random();
int p;
// Проверяем, что количество чисел < 90, если больше, то невозможно записать неповторяющиеся числа.
if ((x * y * z) <= 90)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                p = rnd.Next(10, 100);
                bool b = true;
                // Цикл для проверки рандомного числа на повторение:
                for (int ip = 0; ip < arr.GetLength(0); ip++)
                {
                    for (int jp = 0; jp < arr.GetLength(1); jp++)
                    {
                        for (int kp = 0; kp < arr.GetLength(2); kp++)
                        {
                            if (p == arr[ip, jp, kp])
                            {
                                b = false;
                                k--;
                                break;
                            }
                        }
                    }
                }
                // Если не повторяется — записываем.
                if (b)
                {
                    arr[i,j,k] = p;
                }
            }
        }
    }
    System.Console.WriteLine();
    // Вывод массива.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write(String.Format("{0,5}", arr[i, j, k]) + $"\x1b[32m[{i},{j},{k}]\x1b[0m");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
else System.Console.WriteLine("Недопустимое количество чисел!");