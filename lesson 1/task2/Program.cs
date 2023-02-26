Console.WriteLine("Enter integer");

int var1 = int.Parse(Console.ReadLine());
int var2 = int.Parse(Console.ReadLine());
int var3 = int.Parse(Console.ReadLine());
int max;

if (var1 > var2) {
    max = var1;
} else {
    max = var2;
}
if (max > var3) {
    Console.WriteLine($"Максимальное число = {max}");
} else {
    Console.WriteLine($"Максимальное число = {var1}");
}

