/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
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
        arr[i]=rnd.Next(-99,100);
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
int SumElementsOddIndex(int[] arr)
{
    int sum=0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}
int size=InputNum("Введи количество элементов массива: ");
int[] array=CreateArray(size);
FillArray(array);
PrintArray(array);
int result= SumElementsOddIndex(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");