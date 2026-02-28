// combinaciones posibles de números del 1 al 3 (ejemplo: 1-1, 1-2...)

for (int i =1; i <=3; i++)
{
    for(int j =0; j <= 3; j++)
    {
        Console.WriteLine($"{i}-{j}");
    }
}
