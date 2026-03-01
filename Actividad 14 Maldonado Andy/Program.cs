// Mostrar la tabla de multiplicar de un número ingresado.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());
int i = 1;

while(i <= 10)
{
Console.WriteLine($"{num}x{i} = {num * i}");
    i++;
}
