// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите первую координату точки A по оси X: ");
int xa=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую координату точки A по оси Y: ");
int ya=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью координату точки A по оси Z: ");
int za =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первую координату точки B по оси X: ");
int xb=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую координату точки B по оси Y: ");
int yb=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью координату точки C по оси Z: ");
int zb=Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine($"{res:f2}");