void Sort(){
    Console.Write("Введите количество строк ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[m, n];

    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n; a++)
        {
            array[i, a] = rnd.Next(0,10);
            Console.Write(array[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Отсортированный массив: ");
    int buffer;
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n-1; a++)
        {
            if (array[i, a] < array[i, a+1])
            {
                buffer = array[i, a];
                array[i, a] = array[i, a+1];
                array[i, a+1] = buffer;
                a = -1;
            }
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n; a++)
        {
            Console.Write(array[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }
}

Sort();
