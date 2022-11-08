// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write($"Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] PrintArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}
double[] array = PrintArray(size);
int countPositiveNumber(double[] array)
{
    int count = 0;
    foreach (int value in array)
    {
        if (value > 0)
        {
            count++;
        }
    }
    return count;
}
int result = countPositiveNumber(array);
Console.WriteLine($"\r\nКоличествочисел больше нуля: {result} ");
