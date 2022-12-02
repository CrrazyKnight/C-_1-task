void MaxMin(string[] massive)
{
    if (massive.Length > 1)
    {
        double max = Convert.ToDouble(massive[0]);
        double min = Convert.ToDouble(massive[0]);
        for (int i = 0; i < massive.Length; i++)
        {
            double current = Convert.ToDouble(massive[i]);
            if (current > max)
            {
                max = current;
            }
            else if (current < min)
            {
                min = current;
            }
        }
        Console.WriteLine("\nРазница между максимальным и минимальным элементами массива равна " + (max - min));
    }
    else
    {
        Console.WriteLine("\nРазницы нет, элементов меньше двух");
    }
}

Console.WriteLine("Введите массив числами через пробел");
string[] massive = Console.ReadLine().Split(' ');

MaxMin(massive);
