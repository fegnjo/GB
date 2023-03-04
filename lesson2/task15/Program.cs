Console.WriteLine("Enter digit: ");
int digit = int.Parse(Console.ReadLine());

if (digit == 6 | digit == 7) {
    Console.WriteLine($"{digit} -> да");
} else {
    Console.WriteLine($"{digit} -> нет");
}