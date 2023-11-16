// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int M)
{
    int[] massive = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massive;
}

int CountPositive(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(M);
PrintArray(array);
Console.WriteLine(CountPositive(array));