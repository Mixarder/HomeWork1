/*Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальный из трех чисел это: {a}");
        return;
    }
    Console.WriteLine($"Максимальный из трех чисел это: {c}");
    return;
}
if (b > c)
{
    Console.WriteLine($"Максимальный из трех чисел это: {b}");
    return;
}






