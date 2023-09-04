/* Задача 33:
 Задайте массив. 
 Напишите программу, которая определяет,
  присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да 
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
bool IfFindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true;
    }
    return false;
}
int size = InputNum("Введи размер массива: ");
int num = InputNum("Введи искомое число: ");
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
bool rez = IfFindNum(array, num);
Console.WriteLine(rez==true ? "Да":"Нет");
// if (rez) Console.WriteLine("Да");
// else Console.WriteLine("Нет");