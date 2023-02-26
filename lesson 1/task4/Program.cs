Console.WriteLine("Enter integer");

int var = int.Parse(Console.ReadLine());

for (int i = 1; i <= var; i ++) {
    if ((i % 2) == 0) {
       Console.WriteLine(i);
    } 
}