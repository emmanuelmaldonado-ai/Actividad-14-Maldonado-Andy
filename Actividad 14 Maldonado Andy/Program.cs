//matriz 3x3 con números consecutivos del 1 al 9.

int num = 1;
for (int i =1; i <=3; i++)
{
    for(int j =0; j < 3; j++)
    {
        Console.Write($"{num}");
        num++;
    }
    Console.WriteLine();
}
