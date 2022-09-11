// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if(!isNumber || num < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i * i * i} ");
}