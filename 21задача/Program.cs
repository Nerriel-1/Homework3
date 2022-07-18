// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());

double Distans(int x1Local, int y1Local, int z1Local, int x2Local, int y2Local, int z2Local)
{
    double dis = Math.Sqrt(Math.Pow((x2Local - x1Local), 2) + Math.Pow((y2Local - y1Local), 2) + Math.Pow((z2Local - z1Local), 2));
    return dis;
}
Console.WriteLine(Distans(x1, y1, z1, x2, y2, z2));