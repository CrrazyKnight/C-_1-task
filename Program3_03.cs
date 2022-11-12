string Cubes(int num){
    string answer ="";
    for (int i = 1; i < num+1; i++){
        answer += Convert.ToString(i*i*i);
        answer += ", ";
    }
    answer = answer.Remove(answer.Length - 2, 2);
    return answer;
                         
}

Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());

Console.WriteLine(Cubes(num));
