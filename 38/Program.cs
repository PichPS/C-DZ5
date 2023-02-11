// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] EnterArr()
{
    System.Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите меньшее число массива");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите большее число массива");
    int b = Convert.ToInt32(Console.ReadLine());
    int[] Rand = new int[n];
    for (int i = 0; i < Rand.Length; i++)
    {
        Rand[i] = new Random().Next(a, (b + 1));
    }
    System.Console.Write($"[{string.Join(", ", Rand)}] -> ");
    return Rand;
}

int MIN(int[] Arr)
{
    int min = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] < min) Arr[i] = min;
    }
    System.Console.WriteLine(min);
    return min;
}
int MAX(int[] Arr)
{
    int max = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > max) Arr[i] = max;
    }
    System.Console.WriteLine(max);
    return max;
}

System.Console.WriteLine(MAX(EnterArr())-MIN(EnterArr()));
