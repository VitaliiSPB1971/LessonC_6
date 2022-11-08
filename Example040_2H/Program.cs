// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс,
// найти максимальное число и его индекс. Вывести эту информацию на экран.
Console.Write("Введите число строк:");
int strock = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:");
int stolbec = Convert.ToInt32(Console.ReadLine());
int[,] randomArray(int strock, int stolbec)
{
    int[,] arr = new int[strock, stolbec];
    Console.WriteLine("Массив значений:");
    Random rand = new Random();
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            arr[i, j] = rand.Next(100);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}
int[,] result = randomArray(strock, stolbec);
void printMaxMin(int[,] array)
{
    int min = array[0, 0];
    int max = array[0, 0];
    foreach (int i in array)
    {
        if (min > i)
        {
            min = i;
        }
        if (max < i)
        {
            max = i;
        }
    }
    Console.WriteLine($"Минимальное число: {min} ");
    Console.WriteLine($"Максимальное число: {max} ");
    for (int i = 0; i < strock; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            if (array[i, j].Equals(min))
            {
                Console.WriteLine("Индексы минимального числа: " + i + "-" + j);
            }
            if (array[i, j].Equals(max) || array[1, 1].Equals(max))
            {
                Console.WriteLine("Индексы максимального числа: " + i + "-" + j);
            }
        }
    }
}
printMaxMin(result);
