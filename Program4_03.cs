string array(){
    Console.WriteLine("Введите числа в формате: '2,3,5,...'");
    string data = Console.ReadLine();
    int [] new_n = Array.ConvertAll(data.Split(','),int.Parse);
    string str = ("["+string.Join(", ", new_n)+"]");
    return str;
}
   
Console.WriteLine(array());
