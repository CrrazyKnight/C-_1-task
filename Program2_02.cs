string GetThirdDigit(string num){
    char i;
    if (num.Length > 2){
     i = num[2];
     return Convert.ToString(i);
    }
    else{
    return ("третьей цифры нет");
    }
    
}

Console.WriteLine("Введите число");
string num = Console.ReadLine();

Console.WriteLine(GetThirdDigit(num));
