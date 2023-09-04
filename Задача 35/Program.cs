/* Задача 35: 
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 1000);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int CountElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    }
    return count;
}
int size = InputNum("Введи 123: ");
int[] array = CreateArray(size);
FillArray(array);
int result = CountElements(array);
Console.WriteLine($"{result}");