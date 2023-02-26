Console.WriteLine("Enter integer");

int var = int.Parse(Console.ReadLine());

if ((var % 2) == 0) {
    Console.WriteLine($"{var}->да");
} else {
    Console.WriteLine($"{var}->нет");
}
