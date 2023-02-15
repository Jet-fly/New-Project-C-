/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа: ");
string? chisla = Console.ReadLine();

char[] delimeterChars = { ' ', ',', '.' };
string [] arr = chisla.Split(delimeterChars);

int[] array = new int[arr.Length];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(arr[i]);
    if (array[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество чисел больше нуля: {count}");