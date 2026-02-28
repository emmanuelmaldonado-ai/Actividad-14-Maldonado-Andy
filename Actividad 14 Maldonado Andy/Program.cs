// Mostrar un patrón numérico como:
//1
//22
//333
//4444

for (int i =1; i <=8; i++)
{
    for(int j =1; j <= i; j++)
    {
        Console.Write($"{i}");
    }
    Console.WriteLine();
}
