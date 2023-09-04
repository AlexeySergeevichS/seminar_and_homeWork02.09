/* 
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double[] CreateArray(int size)
{
    return new double[size];
}
void FillArray(double[] arr)
{
    Random rnd = new Random();
    int min = -100;
    int max = 100;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() + rnd.Next(min, max)), 2);
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void DiffMaxMinElemInArray(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else
        if (arr[i] < min) min = arr[i];

    }
    double diff=max-min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: ({max})-({min})={diff}");
}
int size = InputNum("Введи количество элементов массива: ");
double[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
DiffMaxMinElemInArray(array);
