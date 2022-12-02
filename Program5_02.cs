int[] NewArray(int length)
{
    int[] array = new int[length];
    int sum = 0;
    var rnd = new Random();
    if (length > 1) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-9,10);
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
                
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
        }
    else
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-9,10);
                Console.Write("(" + array[i] + ")");
            }
    }
if (length > 1) 
{
    Console.WriteLine("\nСумма чисел на нечетных позициях: " + sum);
}
else
{
    Console.WriteLine("\nВ массиве нет элементов на нечетных позициях");
}
return array;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine());
int[] massive = NewArray(num);
