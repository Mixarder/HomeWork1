//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine(" ВВедите число1 ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2 ");
int b = int.Parse(Console.ReadLine());
int even = a%b;
if(even==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {even}");
}