int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    
    return result;
}
void square(int value)
{
    int i = 1;
    Console.WriteLine($"Введенное число: {value}");
    while(i <= value)
    {
        Console.WriteLine($"{i} -> {Math.Pow(i, 3)}");
        i++;
    }
}

int number = Prompt("Введите число: ");
square(number);


