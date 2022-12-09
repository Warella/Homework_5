// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
double[] FillArrayByRandomNumbers(int size, int left_range, int rigth_range)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(left_range, rigth_range) + rand.NextDouble();
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}
double Difference(double[] arr)
{
    double diff = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i += 2)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    diff = max - min;
    return diff;
}
double[] array = FillArrayByRandomNumbers(9, 0, 10);
Console.WriteLine("[" + string.Join(", ", array) + "]");
double result = Difference(array);
Console.WriteLine("Разница между максимальным и минимальным значениями: " + result);