// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] FillArrayByRandomNumbers(int size, int left_range, int rigth_range)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(left_range, rigth_range);
    }
    return array;
}
int UnEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
int[] array = FillArrayByRandomNumbers(9, 100, 1000);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int result = UnEvenPosition(array);
Console.WriteLine("Сумма чисел на нечетных позициях: " + result);