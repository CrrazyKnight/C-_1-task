void RealNumbers(double[] massive)
{
    double x = (massive[2]-massive[0])/(massive[1]-massive[3]);
    double y = massive[1]*x + massive[0];
    Console.WriteLine("\n(" + x + "; " + y + ")");
}

double[] GetCoordinates()
{
    double[] massive = new double[4];
    Console.Write("b1 = ");
    massive[0] = double.Parse(Console.ReadLine());
    Console.Write("k1 = ");
    massive[1] = double.Parse(Console.ReadLine());
    Console.Write("b2 = ");
    massive[2] = double.Parse(Console.ReadLine());
    Console.Write("k2 = ");
    massive[3] = double.Parse(Console.ReadLine());
    return massive;
}


RealNumbers(GetCoordinates());
