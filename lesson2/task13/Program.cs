
Console.WriteLine("Enter digit: ");
int firstDigit = Math.Abs(int.Parse(Console.ReadLine()));

if (firstDigit / 10 > 9) {
    int digit = firstDigit;

    while (digit / 100 > 9) {
        digit /= 10;
    }

    digit %= 100;
    digit %= 10;

    Console.WriteLine($"{firstDigit} -> {digit}");
} else {
    Console.WriteLine($"{firstDigit} -> третьей цифры нет");
}
