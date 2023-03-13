int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int Pow(int a, int b)
{
    int result = a;
    int i = 1;
    while (i < b)
    {
        result = result * a;
        i++;
    }
    return result;
}

int number1 = Prompt("Введите число: ");
int number2 = Prompt("Введите степень числа: ");

Console.WriteLine(Pow(number1, number2));
