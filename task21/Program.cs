// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координату X первой точки");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X второй точки");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z второй точки");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)), 2);

Console.WriteLine($"Расстояние между точками равно {result}");