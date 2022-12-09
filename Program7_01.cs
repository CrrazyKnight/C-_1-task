void Array(){
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    double[,] array = new double [m, n];


    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int a = 0; a < n; a++)
        {
            int current = rnd.Next(-1000,999);
            array[i, a] = System.Convert.ToDouble(current) / 100;
            Console.Write(array[i, a] + "  ");
        }
    }
}

Array();
