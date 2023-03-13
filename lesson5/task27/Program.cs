string Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

int Count(string value)
{
    int result = 0;

    for (int i = 0; i < value.Length; i++)
    {
        result += value[i] - '0';
    }
    return result;
}

string number = Prompt("Введите число: ");
Console.WriteLine(Count(number));
