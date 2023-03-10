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

int[,] array = new int[5,6];
FillArray(array);
int findNumber = Prompt("Введите число: ");
PrintArray(array);
bool isFound = false;
for (int i = 0; i<5; i++)
{
    for(int j = 0; j<6; j++)
    {
        if(findNumber == array[i,j])
            {
                Console.WriteLine($"Ваше число находится на ({i}, {j})");
                isFound = true;
            }
    }
}
if(isFound == false)
Console.WriteLine("Число не найдено");
