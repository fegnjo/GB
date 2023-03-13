void Array() 
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        string value = Console.ReadLine();
        array[i] = int.Parse(value);
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

Array();