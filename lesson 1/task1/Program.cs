Console.WriteLine("Enter integer");

int var1 = int.Parse(Console.ReadLine());
int var2 = int.Parse(Console.ReadLine());

if (var1 > var2) {
    Console.WriteLine($"Максимальное число = {var1}");
    Console.WriteLine($"Минимальное число = {var2}");
} else {
    Console.WriteLine($"Максимальное число = {var2}");
    Console.WriteLine($"Минимальное число = {var1}");
}

