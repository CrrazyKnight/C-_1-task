int[] NewArray(int length)
{
    int[] array = new int[length];
    int counter = 0;
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,999);
        if (i == 0)
        {
            Console.Write("(" + array[i] + ", ");
        }
        else if (i == array.Length-1)
        {
            Console.Write(array[i] + ")");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
        
        if (array[i] % 2 == 0)
        {
            counter ++;
        }
    }
Console.WriteLine("\nКоличество четных чисел: " + counter);
return array;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine());
int[] massive = NewArray(num);
