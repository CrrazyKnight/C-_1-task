string IfPalindrom(int num){
    string answer = "Да"; 
    string str_num = Convert.ToString(num);
    string str_num2 = "";
    for (int i = 0; i < (str_num.Length); i++){
       str_num2 += str_num[str_num.Length-1-i];
    }
    if (str_num2 == str_num){
            answer = "ДА";
         }
        else{
            answer = "Нет";
        }
    return answer;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(IfPalindrom(num));
