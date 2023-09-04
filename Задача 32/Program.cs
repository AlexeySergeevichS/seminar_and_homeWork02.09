/* Задача 32:
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
        arr[i]=rnd.Next(-9,10);
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
void ChangeArrayElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i]*=-1;  
    }
}
int size=InputNum("Введи размер массива: ");
int[] array=CreateArray(size);
FillArray(array);
PrintArray(array);
ChangeArrayElements(array);
PrintArray(array);