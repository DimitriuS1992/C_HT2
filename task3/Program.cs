// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели:");
int number = int.Parse(Console.ReadLine());

if (number == 1) { Console.WriteLine("Понедельник - не выходной день"); }
else if (number == 2) { Console.WriteLine("Вторник- не выходной день"); }
else if (number == 3) { Console.WriteLine("Среда- не выходной день"); }
else if (number == 4) { Console.WriteLine("Четверг- не выходной день"); }
else if (number == 5) { Console.WriteLine("Пятница- не выходной день"); }
else if (number == 6) { Console.WriteLine("Суббота - выходной день"); }
else if (number == 7) { Console.WriteLine("Воскресенье - выходной день"); }
else { Console.WriteLine("Кривая цифра для проверки дня недели"); }

