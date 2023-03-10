// See https://aka.ms/new-console-template for more information
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
Console.WriteLine();
for(int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        if(i%2==0 && j%2==0)
        {
            array[i,j] = array[i,j]*array[i,j];
        }
    }
}
PrintArray(array);

