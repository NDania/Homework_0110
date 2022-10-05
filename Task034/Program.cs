// Задайте массив заполненный случайными положительными трехзначными
// числами. Напишите программу, которая покажет количество четных чисел 
// в массиве.
Console.Clear();

void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(100,1000);
}

int ReleaseArray(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0)
        count ++;
    }   
    return count;
}

Console.WriteLine("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int []array = new int [n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
ReleaseArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно {ReleaseArray(array)}");


