// See https://aka.ms/new-console-template for more information
int[,] FillArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = new Random().Next(0, 10);
        }
    }
    return massive;
}

void PrintArray(int[,] massive)
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
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = 0;
for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(i==j)
        {
            sum+=array[i,j];
        }
    }
}
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");

