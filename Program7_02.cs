void Search(){
    Console.Write("Введите количество столбцов ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество строк  ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[m, n];


    Console.Write("Введите позиции элемента для поиска через пробел: ");
    string[] number = (Console.ReadLine()).Split(' ');
    int number_x = int.Parse(number[0]);
    int number_y = int.Parse(number[1]);

    if ((number_x < m+1) & (number_y < n+1))
    {
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
    Console.WriteLine(array[number_x-1, number_y-1]);
    }
   else
   {
    Console.WriteLine("Такого числа в массиве нет");
   }
}

Search();
