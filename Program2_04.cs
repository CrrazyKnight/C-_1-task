string GetThirdDigit(int num){
    if ((num % 7 == 0) & (num % 23 == 0)){
     return ("да");
    }
    else{
    return ("нет");
    }
    
}

Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine());

Console.WriteLine(GetThirdDigit(day));
