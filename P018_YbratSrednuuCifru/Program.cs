//Убрать среднюю цифру из случайного трехзначного числа
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num / 100;
int num3 = num % 10;
Console.WriteLine($"{num1}  {num3}");

//Альтернативный вариант
//Console.Clear();
//int num = new Random().Next(100, 1000);
//int result = (num / 100) * 10 + num % 10;
//Console.WriteLine($"{num} -> {result}");
//Console.WriteLine($"{num} -> {num/100}{num%10}");