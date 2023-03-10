// See https://aka.ms/new-console-template for more information
double[,] FillArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-9,9), 1);
        }
    }
    return massive;
}

void PrintArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Количество строк: ");
int n = Prompt("Количество столбцов: ");
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);

