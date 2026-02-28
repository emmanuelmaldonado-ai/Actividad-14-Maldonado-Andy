// triángulo creciente de 5 filas con asteriscos.

for (int fila =0; fila < 5; fila++)
{
    for(int col = 0; col <= fila; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
