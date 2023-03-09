Console.WriteLine("Введите координаты двух точек");
Console.WriteLine("A1: ");
int A1 = int.Parse(Console.ReadLine());
Console.WriteLine("A2: ");
int A2 = int.Parse(Console.ReadLine());
Console.WriteLine("A3: ");
int A3 = int.Parse(Console.ReadLine());
Console.WriteLine("B1: ");
int B1 = int.Parse(Console.ReadLine());
Console.WriteLine("B2: ");
int B2 = int.Parse(Console.ReadLine());
Console.WriteLine("B3: ");
int B3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(A1-B1,2)+Math.Pow(A2-B2,2)+Math.Pow(A3-B3,2));

Console.WriteLine($"A({A1},{A2},{A3}); B({B1},{B2},{B3}) -> {result}");
