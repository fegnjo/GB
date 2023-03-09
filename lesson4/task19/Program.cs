int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if(result < 10000 || result >= 100000)
    {
        Console.WriteLine("Вы ввели не пятизначное число");
        return -1;
    }
    return result;
}

void Check(int value)
{
    int firstTwo = value / 1000;
    int lastTwo = int.Parse($"{value % 10}{(value % 100) / 10}");
    if(firstTwo == lastTwo) Console.WriteLine($"{value} -> Да");
    else Console.WriteLine($"{value} -> нет");

}

int number = Prompt("Введите пятизначное число: ");
Check(number);
