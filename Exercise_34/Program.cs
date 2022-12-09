// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = FillArrayByRandomNumbers(9, 100, 1000);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int result = EvenNumbers(array);
Console.WriteLine("Количество четных чисел: " + result);