
Console.WriteLine("Enter digit: ");
int firstDigit = Math.Abs(int.Parse(Console.ReadLine()));

int digit = firstDigit;

while (digit / 100 > 9) {
    digit /= 10;
}

digit %= 100;
digit %= 10;

Console.WriteLine($"{firstDigit} -> {digit}");

