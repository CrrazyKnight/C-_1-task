int GetThirdDigit(int number){
    int thirdDigit = (number / 10) % 10;
    return thirdDigit;
}

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetThirdDigit(num));
