//№1
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());


if (a > b){
    Console.WriteLine($"max = {a} (первое число больше)");
}
else if (b>a){
    Console.WriteLine($"max = {b} (второе число больше)");
}
else{
    Console.WriteLine($"max = {b} (числа равны)");
}

//№2
int[] nums = {0, 0, 0};
int max = nums[0];
Console.WriteLine("Введите три числа (по одному)");
for (int i = 0; i<3; i++) {
    nums[i] = int.Parse(Console.ReadLine());
    
        if (max < nums[i]){
            max = nums[i];
        }
    
}
Console.WriteLine($"Ответ: {max}");

//№3
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0){
    Console.WriteLine("Да (число четное)");
}
else{
    Console.WriteLine("Нет (число нечетное)");
}

//№4
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int current = 2;
for (int i = 1; i < n; i = i+2){
    Console.Write(current);
        if (i < n-2){
            Console.Write(", ");
        }
    current = current + 2;
}
Console.Write("\b");