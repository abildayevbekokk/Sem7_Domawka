// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Количество строк: ");
int n = Prompt("Количество столбцов: ");
int[,] array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i+j;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

