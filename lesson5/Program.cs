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

Console.WriteLine(Pow(2, 4));