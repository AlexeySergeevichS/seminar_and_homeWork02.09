/* Задача 31: 
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, 
сумма отрицательных равна -20. 
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
void FillArray(int[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(minValue, maxValue + 1);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
       
    }
     Console.WriteLine();
}
int[] Summa(int[] arr)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    int[] rez = new int[2];
    rez[0] = pos;
    rez[1] = neg;
    return rez;
}
// void SumPosNeg(int[] arr)
// {
//     int pos = 0;
//     int neg = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//             pos += arr[i];
//         else
//             neg += arr[i];
//     }
//     Console.WriteLine($"Сумма положительных: {pos}, сумма отрицательных: {neg}");
// }

int size = InputNum("Введи количество элементов массива: ");
int min = InputNum("Введи минимальное значение массива: ");
int max = InputNum("Введи максимальное значение массива: ");
int[] array = CreateArray(size);
FillArray(array, min, max);
PrintArray(array);

int[] rez = Summa(array);
Console.WriteLine($"Сумма положительных: {rez[0]}, сумма отрицательных: {rez[1]}");