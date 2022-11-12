int sum_digits(int num){
    int answer = 0;
            while (num > 0)
            {
                answer = answer + num % 10;
                num = num /10 ;
            }
    return answer;    
}
   
 Console.WriteLine("Введите число");
 int num = Int32.Parse(Console.ReadLine());
 Console.WriteLine(sum_digits(num));
