double Pow(int num_A,int num_B){
    return Math.Pow(num_A, num_B);
                         
}

Console.WriteLine("Введите число");
int num_A = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите степень этого числа");
int num_B = Int32.Parse(Console.ReadLine());

Console.WriteLine(Pow(num_A, num_B));

int Pow2(int num_A, int num_B){
    int answer = 1;
    for (int i = 0; i < num_B; i++){
        answer = answer * num_A;
    }
    return answer;    
}

Console.WriteLine(Pow2(num_A, num_B));
