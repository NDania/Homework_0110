// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

Console.Clear();

void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(-100,101);
}
int ReleaseArray(int[]array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
      
    return sum;
}

Console.WriteLine("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int []array = new int [n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
ReleaseArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {ReleaseArray(array)}");

