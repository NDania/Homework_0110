// Задайте массив вещественных чисел. Найдите разницу между максималь-
// ным и минимальным элементами массива.

Console.Clear();

void InputArray(double[]array)
{
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().NextDouble() * 10;
}
double ReleaseArray(double[]array)
{
    double min = array[0];
    double max = array[1];
    double dif = 0;
    for(int i = 2; i < array.Length; i ++)
    {
        if(array[i] < min)
            min = array [i];
        else
            if(array[i] > max)
                max = array [i];
    }            
    dif = max - min;
    return dif;
}

Console.WriteLine("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double []array = new double [n];
InputArray(array);
Console.WriteLine("[" + string.Join("; ", array) + "]");
ReleaseArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {ReleaseArray(array)}");


