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
int[,] array = new int[5,6];
FillArray(array);
PrintArray(array);

for (int i = 0; i < 6; i++)
{
    double sum = 0;
    for(int j = 0; j < 5; j++)
    {
        sum += array[j,i];
    }
    Console.WriteLine($"Арифметическая средняя в столбце {i}  = {sum/5}");
}
