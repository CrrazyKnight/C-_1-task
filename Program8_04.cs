void Array()
{
    Console.Write("Введите X: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите Y: ");
    int y = int.Parse(Console.ReadLine());
    Console.Write("Введите Z: ");
    int z = int.Parse(Console.ReadLine());

    int[,,] array = new int[x, y, z];
    int[] numbers = new int[x*y*z];
    int counter = 0;
    var rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = rnd.Next(10,99);
                for (int o = 0; o < counter; o++)
                {
                    if (array[i, j, k] == numbers[o])
                    {
                        array[i, j, k] = rnd.Next(10,99);
                        o = -1;
                    }
                }
                numbers[counter] = array[i, j, k];
                counter++;
                Console.Write(array[i, j, k] + "(" + i + ", " + j + ", " + k + ")  ");
            }
            Console.Write("\n");
        }
    }
}
