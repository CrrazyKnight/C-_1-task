void MinStr(){
    Console.Write("Введите количество строк ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int n = int.Parse(Console.ReadLine());
    if (m != n)
    {
        int[,] array = new int[m, n];
        int[,] sum_str = new int[2, m];

        var rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            sum_str[1, i] = i;
            for (int a = 0; a < n; a++)
            {
                array[i, a] = rnd.Next(0,10);
                Console.Write(array[i, a] + "  ");
                sum_str[0, i] += array[i, a];
            }
            Console.WriteLine("\n");
        }
        
        int buffer;
        for (int i = 0; i < m-1; i++)
        {
            if (sum_str[0, i] > sum_str[0, i+1])
            {
                buffer = sum_str[0, i];
                sum_str[0, i] = sum_str[0, i+1];
                sum_str[0, i+1] = buffer;
                buffer = sum_str[1, i];
                sum_str[1, i] = sum_str[1, i+1];
                sum_str[1, i+1] = buffer;
                i = -1;
            }
            
        }

        Console.Write("Строки с наименьшей суммой элементов: ");
        Console.Write((sum_str[1, 0]+1) + " строка");
        if (sum_str[0, 0] == sum_str[0, 1])
        {
            int ind = 1;
            for (int i = 1; i < m-1; i++)
            {
                if (sum_str[0, i] == sum_str[0, i+1])
                {
                    ind++;
                }
            }
            for (int i = 1; i < ind; i++)
            {
                Console.Write(", " + (sum_str[1, i]+1) + " строка");
            }
        } 
        
    }
    else
    {
        MinStr();
    }
    
}

MinStr();
