double Path(string[] a, string[] b){
    
    double x = (Int32.Parse(a[0]) - Int32.Parse(b[0]));
    double y = (Int32.Parse(a[1]) - Int32.Parse(b[1]));
    double z = (Int32.Parse(a[2]) - Int32.Parse(b[2]));
    return Math.Round(Math.Sqrt(x * x + y * y + z * z), 2, MidpointRounding.ToEven);
                         
}

Console.WriteLine("Введите Координаты первой точки через пробел");
string point_a = Console.ReadLine();
Console.WriteLine("Введите Координаты второй точки через пробел");
string point_b = Console.ReadLine();
string[] a = point_a.Split(' ');
string[] b = point_b.Split(' ');

Console.WriteLine(Path(a, b));
