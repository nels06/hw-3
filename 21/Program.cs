// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату X точки A: ");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.Write("Введите координату Y точки A: ");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);
Console.Write("Введите координату Z точки A: ");
bool isNumberZ1 = int.TryParse(Console.ReadLine(), out int z1);

Console.Write("Введите координату X точки B: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.Write("Введите координату Y точки B: ");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);
Console.Write("Введите координату Z точки B: ");
bool isNumberZ2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberX1 || !isNumberY1 || !isNumberZ1 || !isNumberX2 || !isNumberY2 || !isNumberZ2)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

Console.WriteLine($"Расстояние: {GetLength(x1, y1, z1, x2, y2, z2)}");
