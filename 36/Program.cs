// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int OddNumbersSum (int[] Arr)
{
    int Sum = 0;
    for (int i = 1; i < Arr.Length; i+=2)
    {
    Sum = Sum + Arr[i];
    }
System.Console.WriteLine(Sum);
return Sum;
}

OddNumbersSum(EnterArr());