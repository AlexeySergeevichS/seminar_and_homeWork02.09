// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        arr[i] = rnd.Next(1, 10);
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
int[] NewArray(int[] arr)
{
    int newSize = arr.Length / 2 + arr.Length % 2;

    int[] nArr = new int[newSize];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        nArr[i] = arr[i] * arr[arr.Length  -1 - i];
    }
    if (arr.Length % 2 == 1)
        nArr[newSize - 1] = arr[arr.Length / 2];
    return nArr;
}
int size = InputNum("Введи число элементов массива: ");
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
int[] nArray = NewArray(array);
PrintArray(nArray);
