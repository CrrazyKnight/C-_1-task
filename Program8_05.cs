void Array()
{
    int size = 4;
    int[,] array = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        num++;
    }

    for (int a = 0; a < size; a++)
    {
        for (int b = 0; b < size; b++)
        {
            Console.Write(array[a, b] + " ");
            if (array[a, b] < 10)
            {
                Console.Write(" ");
            }
        }
        Console.Write("\n");
    }
}
