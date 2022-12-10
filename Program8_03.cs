void Sort(){
    Console.Write("Введите количество строк 1-й матрицы: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов 2-й матрицы: ");
    int p = int.Parse(Console.ReadLine());

    int[,] first_matrix = new int[m, n];
    Console.WriteLine("Первая матрица: ");
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n; a++)
        {
            first_matrix[i, a] = rnd.Next(0,10);
            Console.Write(first_matrix[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }
    int[,] second_matrix = new int[n, p]; 
    Console.WriteLine("Вторая матрица: ");
    for (int i = 0; i < n; i++)
    {
        for (int a = 0; a < p; a++)
        {
            second_matrix[i, a] = rnd.Next(0,10);
            Console.Write(second_matrix[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }

    int[,] result_matrix = new int[m,p];

    for (int i = 0; i < result_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < result_matrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < first_matrix.GetLength(1); k++)
        {
            sum += first_matrix[i,k] * second_matrix[k,j];
        }
        result_matrix[i,j] = sum;
        }
    }
    Console.WriteLine("Итоговая матрица: ");
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < p; a++)
        {
            Console.Write(result_matrix[i, a] + "  ");
        }
        Console.WriteLine("\n");
    }

}

Sort();
