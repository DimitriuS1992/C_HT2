//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трёхзначное число");
int num1 = int.Parse(Console.ReadLine());
if (num1 > 100 && num1 < 1000)
{
    int num2 = num1 % 10;
    Console.WriteLine($"{num2} - третья цифра нашего трёхначного числа");
}

else if (num1 < 100)
    Console.WriteLine($"Третьей цифры нет");



