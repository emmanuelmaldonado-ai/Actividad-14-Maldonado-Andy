// tabla de multiplicar del 1 al 5 (todas juntas).

for(int tabla =1; tabla <=5; tabla++)
{
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{tabla}x{i} = {tabla * i} ");
    }
    Console.WriteLine();
}
