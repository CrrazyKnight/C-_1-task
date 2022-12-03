void RealNumbers(string[] massive)
{
    int counter = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (int.Parse(massive[i]) > 0)
        {
            counter++;
        }
    }
    Console.WriteLine("\nКоличество чисел больше нуля в массиве: " + counter);
}

Console.WriteLine("Введите массив числами через запятую и пробел (0, 1, 2,...)");
char[] separators = new char[] { ' ', ',' };
string[] massive  = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

RealNumbers(massive);
