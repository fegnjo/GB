Console.WriteLine("Enter digit: ");
int digit = int.Parse(Console.ReadLine());

int hungrets = digit % 100;
int tens = hungrets / 10;

Console.WriteLine(tens);