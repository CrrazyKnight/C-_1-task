string GetThirdDigit(int num){
    if ((num == 6) ^ (num == 7)){
     return ("да");
    }
    else{
    return ("нет");
    }
    
}

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());

Console.WriteLine(GetThirdDigit(day));
