void Search(){
    Console.Write("Введите количество строк ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[m, n];
    double[] average = new double[n];

    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n; a++)
        {
            array[i, a] = rnd.Next(-10,10);
            Console.Write(array[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }
    
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < n; i++)
    {
        for (int a = 0; a < m; a++)
        {
            average[i] += array[a, i];
        }
        Console.Write(average[i]/m);
        if (i < n-1)
        {
            Console.Write("; ");
        }
        else
        {
            Console.Write(".");
        }
    }
}

Search();
